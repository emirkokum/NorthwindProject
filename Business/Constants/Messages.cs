using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Invalid product name";
        internal static string MaintenanceTime = "It is maintenance time";
        internal static string ProductsListed = "Products has listed ";
        internal static string UnitPriceInvalid = "Invalid Unit Price";
        internal static string ProductCountOfCategoryError = "There can be maximum 10 categories";
        internal static string ProductNameAlreadyExists = "Product name already exists";
        internal static string CategoryLimitIsNotOk = "Category limit is full";
        internal static string AuthorizationDenied = "Authorization denied";
        internal static string UserRegistered = "User registered";
        internal static string UserNotFound = "User can not found";
        internal static string PasswordError = "Password Error";
        internal static string SuccessfulLogin = "You logged in successfuly";
        internal static string UserAlreadyExists = "User already exist ";
        internal static string AccessTokenCreated = "Access token created";
    }
}
