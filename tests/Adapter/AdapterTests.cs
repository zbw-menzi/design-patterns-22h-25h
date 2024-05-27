// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace DesignPatterns.Tests.Adapter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.Adapter;

    public class AdapterTests
    {
        [Fact]
        public void PaySalaries_WhenPresidentOfTheBoard_ThenSalaryIncluded()
        {
            var employeeManager = new EmployeeManager();
            //employeeManager.Add(new PresidentOfTheBoard());
        }
    }
}
