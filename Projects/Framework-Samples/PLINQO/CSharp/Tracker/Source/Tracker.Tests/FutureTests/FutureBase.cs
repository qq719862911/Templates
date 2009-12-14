﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using CodeSmith.Data.Linq;
using NUnit.Framework;
using Tracker.Core.Data;

namespace Tracker.Tests.FutureTests
{
    public abstract class FutureBase
    {
        protected List<DateTime> dueDates = new List<DateTime>();
        protected List<DateTime> createDates = new List<DateTime>();
        protected List<int> userIds;
        private List<int> _taskIds = new List<int>();

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            using (var db = new TrackerDataContext())
            {
                

                var users = new List<User>();
                users.Add(new User
                {
                    FirstName = "Testie McTester",
                    LastName = "The First",
                    PasswordHash = "aM/Vndh7cYd3Mxq7msArjl9YU8zoR6fF+sVTSUCcsJi2bx+cwOI0/Bkr5hfq9vYfTe3/rlgPpSMg108acpw+qA",
                    PasswordSalt = "=Unc%",
                    EmailAddress = "one@test.com",
                    IsApproved = false
                });
                users.Add(new User
                {
                    FirstName = "Testie McTester",
                    LastName = "The Second",
                    PasswordHash = "aM/Vndh7cYd3Mxq7msArjl9YU8zoR6fF+sVTSUCcsJi2bx+cwOI0/Bkr5hfq9vYfTe3/rlgPpSMg108acpw+qA",
                    PasswordSalt = "=Unc%",
                    EmailAddress = "two@test.com",
                    IsApproved = false
                });
                users.Add(new User
                {
                    FirstName = "Testie McTester",
                    LastName = "The Third",
                    PasswordHash = "aM/Vndh7cYd3Mxq7msArjl9YU8zoR6fF+sVTSUCcsJi2bx+cwOI0/Bkr5hfq9vYfTe3/rlgPpSMg108acpw+qA",
                    PasswordSalt = "=Unc%",
                    EmailAddress = "three@test.com",
                    IsApproved = false
                });

                var emails = users.Select(u => u.EmailAddress).ToArray();

                var existing = from u in db.User
                               where emails.Contains(u.EmailAddress)
                               select u;

                db.User.Delete(existing);

                db.User.InsertAllOnSubmit(users);
                db.SubmitChanges();
                userIds = users.Select(u => u.Id).ToList();

                dueDates.Add(DateTime.Today.AddDays(1));
                dueDates.Add(DateTime.Today.AddDays(2));

                var tasks = new List<Task>();
                tasks.Add(new Task
                {
                    CreatedId = userIds[0],
                    Priority = Priority.Normal,
                    Status = Status.NotStarted,
                    Summary = "Test",
                    AssignedId = null,
                    DueDate = null,
                    Details = null
                });
                tasks.Add(new Task
                {
                    CreatedId = userIds[1],
                    Priority = Priority.Normal,
                    Status = Status.InProgress,
                    Summary = "Test",
                    AssignedId = userIds[0],
                    DueDate = dueDates[0],
                    Details = String.Empty
                });
                tasks.Add(new Task
                {
                    CreatedId = userIds[2],
                    Priority = Priority.High,
                    Status = Status.Completed,
                    Summary = "Test",
                    AssignedId = userIds[1],
                    DueDate = dueDates[1],
                    Details = "Hello world!"
                });
                tasks.Add(new Task
                {
                    CreatedId = userIds[2],
                    Priority = Priority.High,
                    Status = Status.Completed,
                    Summary = "Test",
                    AssignedId = userIds[1],
                    DueDate = null,
                    Details = "Goodnight moon!"
                });
                db.Task.InsertAllOnSubmit(tasks.Take(1));
                db.SubmitChanges();
                System.Threading.Thread.Sleep(1000);
                db.Task.InsertAllOnSubmit(tasks.Skip(1));
                db.SubmitChanges();

                _taskIds = tasks.Select(t => t.Id).ToList();
                createDates = tasks.Select(t => t.CreatedDate).ToList();
            }
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            using (var db = new TrackerDataContext())
            {
                db.Task.Delete(t => _taskIds.Contains(t.Id));
                db.User.Delete(u => userIds.Contains(u.Id));
            }
        }
    }
}
