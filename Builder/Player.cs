using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Player
    {
        public String name;
        public String team;
        public double height;
        public int salary;
        public String phone;
        public String twitterAccount;

        public class Builder{
            public String name ;
            public String team ;
            public double height = 0;
            public int salary = 0;
            public String phone = "";
            public String twitterAccount = "";

            public  Builder(string name,string team)
            {
                this.name = name;
                this.team = team;
            }

            public Builder Height(double height)
            {
                this.height = height;
                return this;
            }
            public Builder Salary(int salary)
            {
                this.salary = salary;
                return this;
            }
            public Builder Phone(String phone)
            {
                this.phone = phone;
                return this;
            }

            public Builder TwitterAccount(String twitterAccount)
            {
                this.twitterAccount = twitterAccount;
                return this;
            }

            public Player Build()
            {
                return new Player(this);
            }

          
        }

        public Player(Builder builder)
        {
            team = builder.team;
            height = builder.height;
            salary = builder.salary; ;
            phone = builder.phone; ;
            twitterAccount = builder.twitterAccount;


        }

    }
  
}
