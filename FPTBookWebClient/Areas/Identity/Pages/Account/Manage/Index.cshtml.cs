﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using BusinessObjects;
using FPTBookWebClient.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FPTBookWebClient.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IFileService _fileService;

        public IndexModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IFileService fileService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _fileService = fileService;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
			/// <summary>
			///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
			///     directly from your code. This API may change or be removed in future releases.
			/// </summary>
			/// 
			[Required]
			[EmailAddress]
			[Display(Name = "Email")]
			public string Email { get; set; }

			[Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

			[Required(ErrorMessage = "First name can not empty!")]
			[MinLength(2, ErrorMessage = "First name must be more than 2 character!")]
			[MaxLength(100, ErrorMessage = "First name must be lesser than 10 character!")]
			[RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "The First Name must be alphabets!")]
			[Display(Name = "First Name")]
			public string FirstName { get; set; }
			[Required(ErrorMessage = "Last name can not empty!")]
			[MinLength(2, ErrorMessage = "Last name must be more than 2 character!")]
			[MaxLength(100, ErrorMessage = "Last name must be lesser than 10 character!")]
			[RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "The Last Name must be alphabets!")]
			[Display(Name = "Last Name")]
			public string LastName { get; set; }
			[Required(ErrorMessage = "Please choose your gender!")]
			public bool Gender { get; set; }
			[Required(ErrorMessage = "Please choose your birthday!")]
			[ValidBirthday(ErrorMessage = "Birthday can not be greater than current date")]
			public DateTime Birthday { get; set; }
			[Required(ErrorMessage = "Address can not empty!")]
			[MinLength(10, ErrorMessage = "Address must be more than 10 character!")]
			[MaxLength(100, ErrorMessage = "Address must be lesser than 100 character!")]
			public string Address { get; set; }
			public string? ProfilePicture { get; set; }
			public IFormFile ImageFile { get; set; }
        }

        private async Task LoadAsync(AppUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                Email = user.Email,
                PhoneNumber = phoneNumber,
                FirstName = (user.FirstName == null) ? "" : user.FirstName,
                LastName = (user.LastName == null) ? "" : user.LastName,
                Gender = (user.Gender.Value == null) ? true : user.Gender.Value,
                Birthday = (user.Birthday.Value == null) ? new DateTime() : user.Birthday.Value,
                Address = (user.Address == null) ? "" : user.Address,
                ProfilePicture = user.ProfilePicture,
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            if (Input.FirstName != user.FirstName)
            {
                user.FirstName = Input.FirstName;
                await _userManager.UpdateAsync(user);
            }

            if (Input.LastName != user.LastName)
            {
                user.LastName = Input.LastName;
                await _userManager.UpdateAsync(user);
            }

            if (Input.Gender != user.Gender)
            {
                user.Gender = Input.Gender;
                await _userManager.UpdateAsync(user);
            }

            if (Input.Birthday != user.Birthday)
            {
                user.Birthday = Input.Birthday;
                await _userManager.UpdateAsync(user);
            }

            if (Input.Address != user.Address)
            {
                user.Address = Input.Address;
                await _userManager.UpdateAsync(user);
            }

            if (Input.ImageFile != null)
            {
                var result = _fileService.SaveImage(Input.ImageFile);
                if (result.Item1 == 1)
                {
                    var oldImage = user.ProfilePicture;
                    user.ProfilePicture = result.Item2;
                    await _userManager.UpdateAsync(user);
                    var deleteResult = _fileService.DeleteImage(oldImage);
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
