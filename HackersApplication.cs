using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityShowInheritanceComposition
{
    class HackersApplication : ContestantApplication
    {

        #region Properties

        private int CodingExperienceYears { get; set; }
        private string HandleOrAlias { get; set; }
        private int CodeathonWins { get; set; }

        #endregion


        #region Constructors

        public HackersApplication(int CodingExperienceYears, string HandleOrAlias, int CodeathonWins,
            string FirstName, string LastName, DateTime DateofBirth, string Address, string City, string State,
            string Zip, string PhoneNumber, string Email)
            : base(FirstName, LastName, DateofBirth, Address, City, State, Zip, PhoneNumber, Email)
        {

            this.CodingExperienceYears = CodingExperienceYears;
            this.HandleOrAlias = HandleOrAlias;
            this.CodeathonWins = CodeathonWins;

        }

        #endregion

        #region Methods

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine($"{FirstName} {LastName} a.k.a. {HandleOrAlias}, You've been accepted to 'Hackers'. (*Accept() From Child Class - HackersApplication)");

        }

        public void Comment()
        {

            Console.WriteLine($"After contestant {FirstName} {LastName} a.k.a. {HandleOrAlias} logged into the website, " +
                $"there seemed to be a system outage for the entire network. Hmmm...!?! And the lights went out!");

        }

        #endregion
    }
}
