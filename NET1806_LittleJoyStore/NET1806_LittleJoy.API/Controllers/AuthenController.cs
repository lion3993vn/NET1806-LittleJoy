﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET1806_LittleJoy.API.ViewModels.RequestModels;
using NET1806_LittleJoy.API.ViewModels.ResponeModels;
using NET1806_LittleJoy.Service.BusinessModels;
using NET1806_LittleJoy.Service.Services.Interface;

namespace NET1806_LittleJoy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IOtpService _otpService;

        public AuthenController(IUserService userService, IOtpService otpService)
        {
            _userService = userService;
            _otpService = otpService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginWithUsername(LoginRequestModel model)
        {
            try
            {
                var result = await _userService.LoginByUsernameAndPassword(model.Username, model.Password);
                if (result.HttpCode == StatusCodes.Status200OK)
                {
                    return Ok(result);
                }
                else
                {
                    return Unauthorized(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModels()
                {
                    HttpCode = StatusCodes.Status400BadRequest,
                    Message = ex.Message.ToString()
                });
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAccount(RegisterModel model)
        {
            try
            {
                var status = await _userService.RegisterAsync(model);
                var resp = new ResponseModels()
                {
                    HttpCode = StatusCodes.Status200OK,
                    Message = "Create user success"
                };
                return Ok(resp);
            }
            catch (Exception ex)
            {
                var resp = new ResponseModels()
                {
                    HttpCode = StatusCodes.Status400BadRequest,
                    Message = ex.Message.ToString()
                };
                return BadRequest(resp);
            }
        }

        [HttpPost("SendOTP")]
        public async Task<IActionResult> SendOTP([FromBody] string email)
        {
            try
            {
                var result = await _userService.SendOTP(email);
                var resp = new ResponseModels()
                {
                    HttpCode = StatusCodes.Status200OK,
                    Message = "Send OTP Successfully",
                };
                return Ok(resp);
            }
            catch (Exception ex)
            {
                var resp = new ResponseModels()
                {
                    HttpCode = StatusCodes.Status400BadRequest,
                    Message = ex.Message.ToString()
                };
                return BadRequest(resp);
            }
        }

        [HttpPost("VerifyOTP")]
        public async Task<IActionResult> VerifyOTP(OtpRequestModel model)
        {
            try
            {
                //await _otpService.VerifyOtp(model);
                var result = await _otpService.VerifyOtp(model.Email, model.OTPCode);
                if (result)
                {
                    var resp = new ResponseModels()
                    {
                        HttpCode = StatusCodes.Status200OK,
                        Message = "Xác minh thành công",
                    };
                    return Ok(resp);
                }
                return BadRequest(new ResponseModels
                {
                    HttpCode = StatusCodes.Status400BadRequest,
                    Message = "Otp is not valid"
                });
            }
            catch (Exception ex)
            {
                var resp = new ResponseModels()
                {
                    HttpCode = StatusCodes.Status400BadRequest,
                    Message = ex.Message.ToString()
                };
                return BadRequest(resp);
            }
        }

        [HttpPost("AddNewPassword")]
        public async Task<IActionResult> AddNewPassword(AddPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.AddNewPassword(model);
                if (result)
                {
                    var resp = new ResponseModels()
                    {
                        HttpCode = StatusCodes.Status200OK,
                        Message = "Đổi mật khẩu thành công",
                    };
                    return Ok(resp);
                }
                return BadRequest(new ResponseModels()
                {
                    HttpCode = StatusCodes.Status400BadRequest,
                    Message = "Không tìm thấy tài khoản",
                });
            }
            return ValidationProblem(ModelState);
        }

        [HttpPost("Refresh-Token")]
        public async Task<IActionResult> RefreshToken([FromBody] string jwtToken)
        {
            try
            {
                var result = await _userService.RefreshToken(jwtToken);
                if (result.HttpCode == StatusCodes.Status200OK)
                {
                    return Ok(result);
                }
                return Unauthorized(result);
            }
            catch (Exception ex)
            {
                var resp = new ResponseModels()
                {
                    HttpCode = StatusCodes.Status400BadRequest,
                    Message = ex.Message.ToString()
                };
                return BadRequest(resp);
            }
        }
    }
}
