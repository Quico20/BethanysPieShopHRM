using BethanysPieShopHRM.DataAccess.Abstractions;
using BethanysPieShopHRM.Shared.Enums;
using BethanysPieShopHRM.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
		public IEnumerable<Employee> Employees { get; set; }

		[Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

		/* Code placed within OnInitializedAsync Method.
		 * //InitializeCountries();
		 * //InitializeJobCategories();
		 * //InitializeEmployees();*/
		protected override async Task OnInitializedAsync()
        {			
			Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

        #region Obsolete Code created for exercise purposes.
        [Obsolete]
		private List<Country> Countries { get; set; }
		[Obsolete]
		private List<JobCategory> JobCategories { get; set; }

		[Obsolete]
        private void InitializeJobCategories()
		{
			JobCategories = new List<JobCategory>()
			{
				new JobCategory{JobCategoryId = 1, JobCategoryName = "Pie research"},
				new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
				new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
				new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"},
				new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
				new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
				new JobCategory{JobCategoryId = 7, JobCategoryName = "IT"},
				new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
				new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
				new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"}
			};
		}
		[Obsolete]
		private void InitializeCountries()
		{
			Countries = new List<Country>
			{
				new Country {CountryId = 1, CountryName = "Belgium"},
				new Country {CountryId = 2, CountryName = "Netherlands"},
				new Country {CountryId = 3, CountryName = "USA"},
				new Country {CountryId = 4, CountryName = "Japan"},
				new Country {CountryId = 5, CountryName = "China"},
				new Country {CountryId = 6, CountryName = "UK"},
				new Country {CountryId = 7, CountryName = "France"},
				new Country {CountryId = 8, CountryName = "Brazil"}
			};
		}
		[Obsolete]
		private void InitializeEmployees()
		{
			var e1 = new Employee
			{
				CountryId = 1,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1989, 3, 11),
				City = "Brussels",
				Email = "bethany@bethanyspieshop.com",
				EmployeeId = 1,
				FirstName = "Bethany",
				LastName = "Smith",
				Gender = Gender.Female,
				PhoneNumber = "324777888773",
				Smoker = false,
				Street = "Grote Markt 1",
				Zip = "1000",
				JobCategoryId = 1,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2015, 3, 1)
			};

			var e2 = new Employee
			{
				CountryId = 2,
				MaritalStatus = MaritalStatus.Married,
				BirthDate = new DateTime(1979, 1, 16),
				City = "Antwerp",
				Email = "gill@bethanyspieshop.com",
				EmployeeId = 2,
				FirstName = "Gill",
				LastName = "Cleeren",
				Gender = Gender.Female,
				PhoneNumber = "33999909923",
				Smoker = false,
				Street = "New Street",
				Zip = "2000",
				JobCategoryId = 1,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2017, 12, 24)
			};
			Employees = new List<Employee> { e1, e2 };
		}
        #endregion
    }
}
