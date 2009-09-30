﻿
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO NOT MODIFY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Linq
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Linq.Dynamic

Namespace Tracker.Core.Data
    ''' <summary>
    ''' The query extension class for User.
    ''' </summary>
    Public Module UserExtensions
        ''' <summary>
        ''' Gets an instance by the primary key.
        ''' </summary>
        <System.Runtime.CompilerServices.Extension> _
        Public Function GetByKey(ByVal queryable As IQueryable(Of Tracker.Core.Data.User), ByVal id As Integer) As Tracker.Core.Data.User

            Dim entity As System.Data.Linq.Table(Of Tracker.Core.Data.User) = CType(queryable, Table(Of Tracker.Core.Data.User))
            If (entity IsNot Nothing AndAlso entity.Context.LoadOptions Is Nothing) Then
                Return Query.GetByKey.Invoke(DirectCast(entity.Context, Tracker.Core.Data.TrackerDataContext), id)
            End If

            Return queryable.FirstOrDefault(Function(u)u.Id = id)
        End Function
        
        ''' <summary>
        ''' Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        ''' </summary>
        ''' <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        ''' <returns>The number of rows deleted from the database.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function Delete(ByVal table As System.Data.Linq.Table(Of Tracker.Core.Data.User), ByVal id As Integer) As Integer
            Return table.Delete(Function(u)u.Id = id)
        End Function

        ''' <summary>
        ''' Gets an instance by using a unique index.
        ''' </summary>
        ''' <returns>An instance of the entity or null if not found.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function GetByEmailAddress(ByVal queryable As IQueryable(Of Tracker.Core.Data.User), ByVal emailAddress As String) As Tracker.Core.Data.User

            Dim entity As Table(Of Tracker.Core.Data.User) = CType(queryable, Table(Of Tracker.Core.Data.User))
            If (entity IsNot Nothing AndAlso entity.Context.LoadOptions Is Nothing) Then
                Return Query.GetByEmailAddress.Invoke(DirectCast(entity.Context,Tracker.Core.Data.TrackerDataContext), emailAddress)
            End If

            Return queryable.FirstOrDefault(Function(u)u.EmailAddress = emailAddress)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="id">Id to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ById(queryable As IQueryable(Of Tracker.Core.Data.User), id As Integer) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u)u.Id = id)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="id">Id to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ById(queryable As IQueryable(Of Tracker.Core.Data.User), id As Integer, ParamArray additionalValues As Integer()) As IQueryable(Of Tracker.Core.Data.User)
            Dim IdList = New List(Of Integer)()
            IdList.Add(id)
        
            If additionalValues IsNot Nothing Then
                IdList.AddRange(additionalValues)
            End If
        
            If IdList.Count = 1 Then
                Return queryable.ById(IdList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("Id", IdList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="emailAddress">EmailAddress to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByEmailAddress(queryable As IQueryable(Of Tracker.Core.Data.User), emailAddress As String) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u)u.EmailAddress = emailAddress)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="emailAddress">EmailAddress to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByEmailAddress(queryable As IQueryable(Of Tracker.Core.Data.User), emailAddress As String, ParamArray additionalValues As String()) As IQueryable(Of Tracker.Core.Data.User)
            Dim EmailAddressList = New List(Of String)()
            EmailAddressList.Add(emailAddress)
        
            If additionalValues IsNot Nothing Then
                EmailAddressList.AddRange(additionalValues)
            End If
        
            If EmailAddressList.Count = 1 Then
                Return queryable.ByEmailAddress(EmailAddressList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("EmailAddress", EmailAddressList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="firstName">FirstName to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByFirstName(queryable As IQueryable(Of Tracker.Core.Data.User), firstName As String) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u) Object.Equals(u.FirstName, firstName))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="firstName">FirstName to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByFirstName(queryable As IQueryable(Of Tracker.Core.Data.User), firstName As String, ParamArray additionalValues As String()) As IQueryable(Of Tracker.Core.Data.User)
            Dim FirstNameList = New List(Of String)()
            FirstNameList.Add(firstName)
        
            If additionalValues IsNot Nothing Then
                FirstNameList.AddRange(additionalValues)
            Else
                FirstNameList.Add(Nothing)
            End If
        
            If FirstNameList.Count = 1 Then
                Return queryable.ByFirstName(FirstNameList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("FirstName", FirstNameList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="lastName">LastName to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByLastName(queryable As IQueryable(Of Tracker.Core.Data.User), lastName As String) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u) Object.Equals(u.LastName, lastName))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="lastName">LastName to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByLastName(queryable As IQueryable(Of Tracker.Core.Data.User), lastName As String, ParamArray additionalValues As String()) As IQueryable(Of Tracker.Core.Data.User)
            Dim LastNameList = New List(Of String)()
            LastNameList.Add(lastName)
        
            If additionalValues IsNot Nothing Then
                LastNameList.AddRange(additionalValues)
            Else
                LastNameList.Add(Nothing)
            End If
        
            If LastNameList.Count = 1 Then
                Return queryable.ByLastName(LastNameList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("LastName", LastNameList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="createdDate">CreatedDate to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByCreatedDate(queryable As IQueryable(Of Tracker.Core.Data.User), createdDate As Date) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u)u.CreatedDate = createdDate)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="createdDate">CreatedDate to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByCreatedDate(queryable As IQueryable(Of Tracker.Core.Data.User), createdDate As Date, ParamArray additionalValues As Date()) As IQueryable(Of Tracker.Core.Data.User)
            Dim CreatedDateList = New List(Of Date)()
            CreatedDateList.Add(createdDate)
        
            If additionalValues IsNot Nothing Then
                CreatedDateList.AddRange(additionalValues)
            End If
        
            If CreatedDateList.Count = 1 Then
                Return queryable.ByCreatedDate(CreatedDateList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("CreatedDate", CreatedDateList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="modifiedDate">ModifiedDate to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByModifiedDate(queryable As IQueryable(Of Tracker.Core.Data.User), modifiedDate As Date) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u)u.ModifiedDate = modifiedDate)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="modifiedDate">ModifiedDate to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByModifiedDate(queryable As IQueryable(Of Tracker.Core.Data.User), modifiedDate As Date, ParamArray additionalValues As Date()) As IQueryable(Of Tracker.Core.Data.User)
            Dim ModifiedDateList = New List(Of Date)()
            ModifiedDateList.Add(modifiedDate)
        
            If additionalValues IsNot Nothing Then
                ModifiedDateList.AddRange(additionalValues)
            End If
        
            If ModifiedDateList.Count = 1 Then
                Return queryable.ByModifiedDate(ModifiedDateList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("ModifiedDate", ModifiedDateList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="passwordHash">PasswordHash to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByPasswordHash(queryable As IQueryable(Of Tracker.Core.Data.User), passwordHash As String) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u)u.PasswordHash = passwordHash)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="passwordHash">PasswordHash to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByPasswordHash(queryable As IQueryable(Of Tracker.Core.Data.User), passwordHash As String, ParamArray additionalValues As String()) As IQueryable(Of Tracker.Core.Data.User)
            Dim PasswordHashList = New List(Of String)()
            PasswordHashList.Add(passwordHash)
        
            If additionalValues IsNot Nothing Then
                PasswordHashList.AddRange(additionalValues)
            End If
        
            If PasswordHashList.Count = 1 Then
                Return queryable.ByPasswordHash(PasswordHashList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("PasswordHash", PasswordHashList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="passwordSalt">PasswordSalt to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByPasswordSalt(queryable As IQueryable(Of Tracker.Core.Data.User), passwordSalt As String) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u)u.PasswordSalt = passwordSalt)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="passwordSalt">PasswordSalt to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByPasswordSalt(queryable As IQueryable(Of Tracker.Core.Data.User), passwordSalt As String, ParamArray additionalValues As String()) As IQueryable(Of Tracker.Core.Data.User)
            Dim PasswordSaltList = New List(Of String)()
            PasswordSaltList.Add(passwordSalt)
        
            If additionalValues IsNot Nothing Then
                PasswordSaltList.AddRange(additionalValues)
            End If
        
            If PasswordSaltList.Count = 1 Then
                Return queryable.ByPasswordSalt(PasswordSaltList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("PasswordSalt", PasswordSaltList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="comment">Comment to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByComment(queryable As IQueryable(Of Tracker.Core.Data.User), comment As String) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u) Object.Equals(u.Comment, comment))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="comment">Comment to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByComment(queryable As IQueryable(Of Tracker.Core.Data.User), comment As String, ParamArray additionalValues As String()) As IQueryable(Of Tracker.Core.Data.User)
            Dim CommentList = New List(Of String)()
            CommentList.Add(comment)
        
            If additionalValues IsNot Nothing Then
                CommentList.AddRange(additionalValues)
            Else
                CommentList.Add(Nothing)
            End If
        
            If CommentList.Count = 1 Then
                Return queryable.ByComment(CommentList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("Comment", CommentList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="isApproved">IsApproved to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByIsApproved(queryable As IQueryable(Of Tracker.Core.Data.User), isApproved As Boolean) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u)u.IsApproved = isApproved)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="isApproved">IsApproved to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByIsApproved(queryable As IQueryable(Of Tracker.Core.Data.User), isApproved As Boolean, ParamArray additionalValues As Boolean()) As IQueryable(Of Tracker.Core.Data.User)
            Dim IsApprovedList = New List(Of Boolean)()
            IsApprovedList.Add(isApproved)
        
            If additionalValues IsNot Nothing Then
                IsApprovedList.AddRange(additionalValues)
            End If
        
            If IsApprovedList.Count = 1 Then
                Return queryable.ByIsApproved(IsApprovedList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("IsApproved", IsApprovedList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="lastLoginDate">LastLoginDate to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByLastLoginDate(queryable As IQueryable(Of Tracker.Core.Data.User), lastLoginDate As Date?) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u) Object.Equals(u.LastLoginDate, lastLoginDate))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="lastLoginDate">LastLoginDate to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByLastLoginDate(queryable As IQueryable(Of Tracker.Core.Data.User), lastLoginDate As Date?, ParamArray additionalValues As Date?()) As IQueryable(Of Tracker.Core.Data.User)
            Dim LastLoginDateList = New List(Of Date?)()
            LastLoginDateList.Add(lastLoginDate)
        
            If additionalValues IsNot Nothing Then
                LastLoginDateList.AddRange(additionalValues)
            Else
                LastLoginDateList.Add(Nothing)
            End If
        
            If LastLoginDateList.Count = 1 Then
                Return queryable.ByLastLoginDate(LastLoginDateList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("LastLoginDate", LastLoginDateList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="lastActivityDate">LastActivityDate to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByLastActivityDate(queryable As IQueryable(Of Tracker.Core.Data.User), lastActivityDate As Date) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u)u.LastActivityDate = lastActivityDate)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="lastActivityDate">LastActivityDate to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByLastActivityDate(queryable As IQueryable(Of Tracker.Core.Data.User), lastActivityDate As Date, ParamArray additionalValues As Date()) As IQueryable(Of Tracker.Core.Data.User)
            Dim LastActivityDateList = New List(Of Date)()
            LastActivityDateList.Add(lastActivityDate)
        
            If additionalValues IsNot Nothing Then
                LastActivityDateList.AddRange(additionalValues)
            End If
        
            If LastActivityDateList.Count = 1 Then
                Return queryable.ByLastActivityDate(LastActivityDateList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("LastActivityDate", LastActivityDateList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="lastPasswordChangeDate">LastPasswordChangeDate to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByLastPasswordChangeDate(queryable As IQueryable(Of Tracker.Core.Data.User), lastPasswordChangeDate As Date?) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u) Object.Equals(u.LastPasswordChangeDate, lastPasswordChangeDate))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="lastPasswordChangeDate">LastPasswordChangeDate to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByLastPasswordChangeDate(queryable As IQueryable(Of Tracker.Core.Data.User), lastPasswordChangeDate As Date?, ParamArray additionalValues As Date?()) As IQueryable(Of Tracker.Core.Data.User)
            Dim LastPasswordChangeDateList = New List(Of Date?)()
            LastPasswordChangeDateList.Add(lastPasswordChangeDate)
        
            If additionalValues IsNot Nothing Then
                LastPasswordChangeDateList.AddRange(additionalValues)
            Else
                LastPasswordChangeDateList.Add(Nothing)
            End If
        
            If LastPasswordChangeDateList.Count = 1 Then
                Return queryable.ByLastPasswordChangeDate(LastPasswordChangeDateList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("LastPasswordChangeDate", LastPasswordChangeDateList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="avatarType">AvatarType to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByAvatarType(queryable As IQueryable(Of Tracker.Core.Data.User), avatarType As String) As IQueryable(Of Tracker.Core.Data.User)
            Return queryable.Where(Function(u) Object.Equals(u.AvatarType, avatarType))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="Tracker.Core.Data.User"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="avatarType">AvatarType to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByAvatarType(queryable As IQueryable(Of Tracker.Core.Data.User), avatarType As String, ParamArray additionalValues As String()) As IQueryable(Of Tracker.Core.Data.User)
            Dim AvatarTypeList = New List(Of String)()
            AvatarTypeList.Add(avatarType)
        
            If additionalValues IsNot Nothing Then
                AvatarTypeList.AddRange(additionalValues)
            Else
                AvatarTypeList.Add(Nothing)
            End If
        
            If AvatarTypeList.Count = 1 Then
                Return queryable.ByAvatarType(AvatarTypeList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of Tracker.Core.Data.User, Boolean)("AvatarType", AvatarTypeList)
            Return queryable.Where(expression)
        End Function

        'Insert User Defined Extensions here.
        'Anything outside of this Region will be lost at regeneration
        #Region "User Extensions"


        #End Region

        #Region "Query"
        ''' <summary>
        ''' A private class for lazy loading static compiled queries.
        ''' </summary>
        Private Partial Class Query


            Friend Shared ReadOnly GetByKey As Func(Of TrackerDataContext, Integer, Tracker.Core.Data.User) = _
                CompiledQuery.Compile( _
                    Function(db As TrackerDataContext , ByVal id As Integer) _
                        db.User.FirstOrDefault(Function(u)u.Id = id))

            Friend Shared ReadOnly GetByEmailAddress As Func(Of TrackerDataContext, String, Tracker.Core.Data.User) = _
                CompiledQuery.Compile( _
                    Function(db As TrackerDataContext , ByVal emailAddress As String) _
                        db.User.FirstOrDefault(Function(u)u.EmailAddress = emailAddress))

            ' Add your compiled queries here.
            'Anything outside of this Region will be lost at regeneration
            #Region "User Queries"

            #End Region

        End Class
        #End Region
    End Module
End Namespace

