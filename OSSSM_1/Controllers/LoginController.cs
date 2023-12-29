﻿using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OSSSM_1.DAO;
using OSSSM_1.Models;
using OSSSM_1.Models.Login;

namespace OSSSM_1.Controllers
{
    public class LoginController : Controller
    {

        // Index

        public IActionResult ChangeToLoginIndex() //Action đệm, tránh HttpPost
        {

            return RedirectToAction("Index", "Login");
        }
        [HttpGet]
        public IActionResult Index()
        {
            AccountLoginInput accountLoginInput = new AccountLoginInput();

            accountLoginInput.UserName = TempData["AccName"] == null ? null : TempData["AccName"].ToString(); // Lưu thông tin người dùng nhập
            TempData["AccName"] = null;
            accountLoginInput.Password = TempData["Password"] == null ? null : TempData["Password"].ToString();
            TempData["Password"] = null;
            String loginSubmit = TempData["LoginSubmit"] == null ? "0" : TempData["LoginSubmit"].ToString();


            if (loginSubmit == "1")
            {
                if (accountLoginInput.UserName == null) // Chưa nhập tên đăng nhập
                {
                    TempData["msg"] = "Vui lòng nhập tên đăng nhập!";
                    return View("./Views/Shared/Login/Login.cshtml", accountLoginInput);
                }

                Account user = AccountDAO.Instance.GetAccountbyUsername(accountLoginInput.UserName);

                if (user == null && loginSubmit == "1")  // Không tìm thấy tên đăng nhập trong database
                {
                    TempData["msg"] = "Tài khoản không tồn tại!";
                    return View("./Views/Shared/Login/Login.cshtml", accountLoginInput);
                }

                // Tìm thấy tên đăng nhập trong database
                if (accountLoginInput.Password == null) // Chưa nhập mật khẩu
                {
                    TempData["msg"] = "Vui lòng nhập mật khẩu";
                    return View("./Views/Shared/Login/Login.cshtml", accountLoginInput);
                }

                else if (accountLoginInput.Password != user.Password) // Nhập sai mật khẩu
                {
                    TempData["msg"] = "Bạn nhập sai mật khẩu!";
                    return View("./Views/Shared/Login/Login.cshtml", accountLoginInput);
                }
                else // Đúng mật khẩu và chuyển hướng loại tài khoản
                {
                    var userSession = new UserLogin();
                    userSession.UserName = user.Username;

                    
                   return RedirectToAction("Index", "Management");

                }
               
            }
            return View("./Views/Shared/Login/Login.cshtml", accountLoginInput);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AccountLoginInput input)
        {
            TempData["AccName"] = input.UserName;
            TempData["Password"] = input.Password;
            TempData["LoginSubmit"] = "1";
            return RedirectToAction("Index", "Login");
        }
        // End Index

        // Đổi mật khẩu

        public IActionResult ChangeToChangePassword() //Action đệm, tránh HttpPost
        {
            return RedirectToAction("ChangePassword", "Login");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            var userSession = JsonConvert.DeserializeObject<UserLogin>(HttpContext.Session.GetString("LoginSession"));
            Account user = AccountDAO.Instance.GetAccountbyUsername(userSession.UserName);
            ChangePasswordInput changePasswordInput = new ChangePasswordInput();

            changePasswordInput.OldPassword = TempData["OldPass"] == null ? null : TempData["OldPass"].ToString(); // Lưu thông tin người dùng nhập
            TempData["OldPass"] = null;
            changePasswordInput.NewPassword = TempData["NewPass"] == null ? null : TempData["NewPass"].ToString();
            TempData["NewPass"] = null;
            changePasswordInput.ReNewPassword = TempData["ReNewPass"] == null ? null : TempData["ReNewPass"].ToString();
            TempData["ReNewPass"] = null;
            String changePassSubmit = TempData["ChangePassSubmit"] == null ? "0" : TempData["ChangePassSubmit"].ToString();


            if (changePassSubmit == "1")
            {
                if (changePasswordInput.OldPassword == null)
                {
                    TempData["msg"] = "Vui lòng nhập mật khẩu cũ";
                }
                else if (changePasswordInput.OldPassword != user.Password)
                {
                    TempData["msg"] = "Bạn nhập sai mật khẩu hiện tại!";
                }
                else if (changePasswordInput.NewPassword == null)
                {
                    TempData["msg"] = "Vui lòng nhập mật khẩu mới";
                }
                else if (changePasswordInput.ReNewPassword == null)
                {
                    TempData["msg"] = "Vui lòng xác nhận lại mật khẩu mới";
                }

                else if (changePasswordInput.OldPassword == user.Password)
                {
                    if (changePasswordInput.NewPassword != changePasswordInput.ReNewPassword) TempData["msg"] = "Mật khẩu xác nhận không trùng khớp!";
                    else
                    {
                        TempData["msg"] = "Đổi mật khẩu thành công!";
                        AccountDAO.Instance.ChangePassword(user.Username, changePasswordInput.NewPassword);
                        return RedirectToAction("ChangeToLoginIndex", "Login");
                    }
                }
            }

            return View("./Views/Shared/Login/ChangePassword.cshtml", changePasswordInput);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(ChangePasswordInput input)
        {
            TempData["OldPass"] = input.OldPassword;
            TempData["NewPass"] = input.NewPassword;
            TempData["ReNewPass"] = input.ReNewPassword;
            TempData["ChangePassSubmit"] = "1";
            return RedirectToAction("ChangePassword", "Login");

        }

        //
        public IActionResult ChangeToForgotPassword() //Action đệm, tránh HttpPost
        {
            return RedirectToAction("ForgotPassword", "Login");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View("./Views/Shared/Login/ForgotPassword.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ForgotPassword(String accName, String pass)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
