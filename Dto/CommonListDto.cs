using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBS.Common.Services.Dto
{
    public class CommonListDto
    {

        public int Value { get; set; }

        public string Text { get; set; }

    }

    public class AllComplianceTypeDto
    {
        public int Value { get; set; }

        public string Text { get; set; }

        public string Group { get; set; }
    }

    public class LicenceTypeDto
    {

        public int Value { get; set; }

        public string Text { get; set; }


    }
}
