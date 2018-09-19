using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using CBS.Common.Services.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CBS.Common.Services.Service
{
    public class CommonList
    {

        public IList<CommonListDto> GenderList()
        {
            IList<CommonListDto> genderlist = new List<CommonListDto>();

            var unknown = new CommonListDto()
            {
                Text = "Prefer Not Say",
                Value = 0
            };

            var male = new CommonListDto()
            {
                Text = "Male",
                Value = 1
            };

            var female = new CommonListDto()
            {
                Text = "Female",
                Value = 2
            };

            genderlist.Add(unknown);
            genderlist.Add(male);
            genderlist.Add(female);

            return genderlist;
        }


        public IList<SelectListItem> GenderListItems()
        {
            IList<SelectListItem> genderlist = new List<SelectListItem>();

            var unknown = new SelectListItem()
            {
                Text = "Prefer Not Say",
                Value = "0"
            };

            var male = new SelectListItem()
            {
                Text = "Male",
                Value = "1"
            };

            var female = new SelectListItem()
            {
                Text = "Female",
                Value = "2"
            };

            genderlist.Add(unknown);
            genderlist.Add(male);
            genderlist.Add(female);

            return genderlist;
        }

        //public IList<CommonListDto> ProficiencyList()
        //{
        //    IList<CommonListDto> proflist = new List<CommonListDto>();

        //    var beginner = new CommonListDto()
        //    {
        //        Text = "Beginner",
        //        Value = 1
        //    };

        //    var intermediate = new CommonListDto()
        //    {
        //        Text = "Intermediate",
        //        Value = 2
        //    };

        //    var advanced = new CommonListDto()
        //    {
        //        Text = "Advanced",
        //        Value = 3
        //    };

        //    proflist.Add(beginner);
        //    proflist.Add(intermediate);
        //    proflist.Add(advanced);

        //    return proflist;
        //}

        public IList<SelectListItem> ProficiencyList()
        {
            IList<SelectListItem> proflist = new List<SelectListItem>();

            var beginner = new SelectListItem()
            {
                Text = "Beginner",
                Value = "1"
            };

            var basic = new SelectListItem()
            {
                Text = "Basic Understanding",
                Value = "2"
            };

            var intermediate = new SelectListItem()
            {
                Text = "Intermediate",
                Value = "3"
            };

            var advanced = new SelectListItem()
            {
                Text = "Advanced",
                Value = "4"
            };

            var native = new SelectListItem()
            {
                Text = "Native Speaker",
                Value = "5"
            };

            proflist.Add(beginner);
            proflist.Add(basic);
            proflist.Add(intermediate);
            proflist.Add(advanced);
            proflist.Add(native);

            return proflist;
        }

        public IList<SelectListItem> EmployeeTypeList()
        {
            IList<SelectListItem> genderlist = new List<SelectListItem>();

            var unknown = new SelectListItem()
            {
                Text = "Employee",
                Value = "1"
            };

            var male = new SelectListItem()
            {
                Text = "Volunteer",
                Value = "2"
            };

            var female = new SelectListItem()
            {
                Text = "Agency",
                Value = "3"
            };

            genderlist.Add(unknown);
            genderlist.Add(male);
            genderlist.Add(female);

            return genderlist;
        }

        public IList<SelectListItem> ComplianceStatusList()
        {
            IList<SelectListItem> StatusList = new List<SelectListItem>();

            var valid = new SelectListItem()
            {
                Text = "Valid",
                Value = "1"
            };

            var invalid = new SelectListItem()
            {
                Text = "Invalid",
                Value = "2"
            };

            var missing = new SelectListItem()
            {
                Text = "Missing",
                Value = "3"
            };

            var incomplete = new SelectListItem()
            {
                Text = "Incomplete",
                Value = "4"
            };

            StatusList.Add(valid);
            StatusList.Add(invalid);
            StatusList.Add(missing);
            StatusList.Add(incomplete);

            return StatusList;
        }


        public IList<LicenceTypeDto> LicenceTypeList()
        {
            IList<LicenceTypeDto> TypeList = new List<LicenceTypeDto>();

            var driving = new LicenceTypeDto()
            {
                Text = "Driving Licence",
                Value = 1
            };

            var boat = new LicenceTypeDto()
            {
                Text = "Boat Licence",
                Value = 2
            };

            var gun = new LicenceTypeDto()
            {
                Text = "Gun Permit",
                Value = 3
            };

            TypeList.Add(driving);
            TypeList.Add(boat);
            TypeList.Add(gun);

            return TypeList;
        }

        public IList<SelectListItem> GetUserRoles()
        {
            IList<SelectListItem> userRoles = new List<SelectListItem>();

            var admin = new SelectListItem()
            {
                Text = "SuperAdmin",
                Value = "1"
            };

            var manager = new SelectListItem()
            {
                Text = "Manager",
                Value = "2"
            };

            var employee = new SelectListItem()
            {
                Text = "Employee",
                Value = "3"
            };

            userRoles.Add(admin);
            userRoles.Add(manager);
            userRoles.Add(employee);

            return userRoles;

        }

        public IList<CommonListDto> BackgroundTypeList()
        {
            IList<CommonListDto> backgroundList = new List<CommonListDto>();

            var police = new CommonListDto()
            {
                Text = "Police Check",
                Value = 1
            };

            var wwChildren = new CommonListDto()
            {
                Text = "Work With Children",
                Value = 2
            };

            backgroundList.Add(police);
            backgroundList.Add(wwChildren);

            return backgroundList;
        }

        public IList<SelectListItem> PerformanceTypePeriod()
        {
            IList<SelectListItem> periodList = new List<SelectListItem>();

            periodList.Add(new SelectListItem()
            {
                Text = "N/A",
                Value = "-1"
            });

            periodList.Add(new SelectListItem()
            {
                Text = "1 Month",
                Value = "1"
            });

            periodList.Add(new SelectListItem()
            {
                Text = "3 Month",
                Value = "2"
            });

            periodList.Add(new SelectListItem()
            {
                Text = "6 Month",
                Value = "3"
            });

            periodList.Add(new SelectListItem()
            {
                Text = "1 Year",
                Value = "4"
            });

            periodList.Add(new SelectListItem()
            {
                Text = "Permanent",
                Value = "0"
            });

            return periodList;

        }


    }


}
