namespace MyTube2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //Pay as you go
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            //Monthly
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            //Quarterly
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            //Annually 
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (12, 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
