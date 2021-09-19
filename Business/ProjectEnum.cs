using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Business
{
    public enum ReportEnum
    {
        // Loan and Advance Report
        // Advance
        Advance_All = 1,
        Advance_Cash = 2,
        Advance_Bank = 3,

        // Loan
        Loan_All = 4,
        Loan_Cash = 5,
        Loan_Bank = 6,
        Loan_Payment = 7,

        // Employees
        All_Employee_Details = 8,
        Employee_Clearance = 9,

        // Attendance 
        Shift_Wise = 10,

        // Salary Reports
        Total_Earning = 11,
        Total_Deductions = 12,
        Earning_and_Deduction = 13,
        Bank_Payment = 14,
        Cash_Payment = 15,
        Late_Payment = 16,

        // Salary Deductions
        Death_Donation_Deductions = 17,
        Medical_Checkup_Deductions = 18,
        Uniform_Deductions = 19,
        Sport_Uniform_Deductions = 20,
        Loan_Recovery_Deductions = 21,
        Salary_Advance_Deductions = 22,
        Meal_Deductions = 23,
        Insurance_Deductions = 24,
        Special_Deductions_ll = 25,
        Fine_and_Penalty_Deductions = 26,
        Mobile_Phone_Deductions = 27,
        Donation_Recovery_Deductions = 28,
        Festival_Advance_Deductions = 29,
        Welfare_Deductions = 30,

        //Pay Reports
        Pay_slip = 31,
        Pay_sheet = 32,
        Pay_Summary = 33,
        Pay_Analyzer = 34,

        // EPF/ETF Reports  
        EPF_ETF_H_O_List = 35,
        EPF_ETF_Statement = 36,
        ETF_6_Month_Return = 37,
        EPF_E_Return = 38,

        // Deduction Balance 
        Insurance = 39,
        Uniform = 40,
        Sport_Uniforms = 41,
        Fine_And_Penalty = 42,
        Donations = 43,
        Festival_Advance = 44,
        Death_Deductions = 45,
        Fixed_Deductions = 46,

        // Locations 
        Locations_Report = 47,

    }
}
