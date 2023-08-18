using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waspbot
{
    internal class Student
    {
        private int chat_id;
        private string name;
        private string surname;
        private string patronymic;
        private int phone_number;
        private string email;
        private string city;
        private string educational_institution;
        private string date_and_time_of_offline_test;
        private int offline_test_points;
        private int interview_points;
        private string status;
        public Student()
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.chat_id = chat_id;
            this.phone_number = phone_number;
            this.email = email;
            this.city = city;
            this.educational_institution = educational_institution;
        }

        public int GetChat_Id
        {
            get
            {
                return chat_id;
            }
            set
            {
                chat_id = value;
            }
        }
        public string GetName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string GetSurname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string GetPatronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
            }
        }
        public int GetPhone_Number
        {
            get
            {
                return phone_number;
            }
            set
            {
                phone_number = value;
            }
        }
        public string GetEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string GetCity
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string GetEducational_Institution
        {
            get
            {
                return educational_institution;
            }
            set
            {
                educational_institution = value;
            }
        }
        public string GetDate_And_Time_Of_Offline_Test
        {
            get
            {
                return date_and_time_of_offline_test;
            }
            set
            {
                date_and_time_of_offline_test = value;
            }
        }
    }
}
