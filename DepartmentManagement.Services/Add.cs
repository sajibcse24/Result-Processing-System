using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DepartmentManagement.Services
{
    public class Add
    {


        public Add()
        {
            Id = 0;
            Roll = String.Empty;
            Name = String.Empty;
            Session = String.Empty;
            Psession = String.Empty; //for readd students
            Registration_no = String.Empty;
            Sex = String.Empty;
            Current_semester = String.Empty;
            Current_semester_gpa = String.Empty;
            Cgpa = String.Empty;
            Blood_group = String.Empty;
            Mobile_no = String.Empty;
            Email = String.Empty;
            Designation = String.Empty;
            Dateofjoin = String.Empty;
            Username = String.Empty;
            Password = String.Empty;
            Attendance = String.Empty;
            Mid1 = String.Empty;
            Mid2 = String.Empty;
            Assignment = String.Empty;
            Presentation = String.Empty;
            Classtest = String.Empty;
            Totalmarks = String.Empty;
            Year = String.Empty;

            Semester = String.Empty;      // for syllabus
            Course_code = String.Empty;
            Course_title = String.Empty;
            Course_credit = String.Empty;

            Before_final = string.Empty;        // for GPA calculation
            Internal_marks = String.Empty;
            External_marks = String.Empty;
            Third_marks = String.Empty;
            Letter_grade = String.Empty;
            Gpa = String.Empty;
            Total_gpa = String.Empty;
            Total_credit = String.Empty;

            Gpa_credit = String.Empty;
            Fgpa = String.Empty;
            Fcgpa = String.Empty;
            Gpa_history = String.Empty; //course gpa for improvement
            Cgpa_history = String.Empty;
            Semester_gpa_credit = String.Empty;
            Remarks = String.Empty;
            Viva_marks = String.Empty;






        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string roll;
        public string Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string session;

        public string Session
        {
            get { return session; }
            set { session = value; }
        }
        private string psession;

        public string Psession
        {
            get { return psession; }
            set { psession = value; }
        }

        private string registration_no;

        public string Registration_no
        {
            get { return registration_no; }
            set { registration_no = value; }
        }
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string current_semester;

        public string Current_semester
        {
            get { return current_semester; }
            set { current_semester = value; }
        }
        private string current_semester_gpa;

        public string Current_semester_gpa
        {
            get { return current_semester_gpa; }
            set { current_semester_gpa = value; }
        }
        private string cgpa;

        public string Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private string blood_group;

        public string Blood_group
        {
            get { return blood_group; }
            set { blood_group = value; }
        }
        private string mobile_no;

        public string Mobile_no
        {
            get { return mobile_no; }
            set { mobile_no = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        private string dateofjoin;

        public string Dateofjoin
        {
            get { return dateofjoin; }
            set { dateofjoin = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string attendance;

        public string Attendance
        {
            get { return attendance; }
            set { attendance = value; }
        }
        private string mid1;

        public string Mid1
        {
            get { return mid1; }
            set { mid1 = value; }
        }
        private string mid2;

        public string Mid2
        {
            get { return mid2; }
            set { mid2 = value; }
        }
        private string assignment;

        public string Assignment
        {
            get { return assignment; }
            set { assignment = value; }
        }
        private string presentation;

        public string Presentation
        {
            get { return presentation; }
            set { presentation = value; }
        }
        private string classtest;

        public string Classtest
        {
            get { return classtest; }
            set { classtest = value; }
        }
        private string totalmarks;

        public string Totalmarks
        {
            get { return totalmarks; }
            set { totalmarks = value; }
        }
        private string year;             // for syllabus

        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        private string semester;

        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        private string course_code;

        public string Course_code
        {
            get { return course_code; }
            set { course_code = value; }
        }
        private string course_title;

        public string Course_title
        {
            get { return course_title; }
            set { course_title = value; }
        }
        private string course_credit;

        public string Course_credit
        {
            get { return course_credit; }
            set { course_credit = value; }
        }


        private string before_final;         // for GPA calculation

        public string Before_final
        {
            get { return before_final; }
            set { before_final = value; }
        }
        private string internal_marks;

        public string Internal_marks
        {
            get { return internal_marks; }
            set { internal_marks = value; }
        }
        private string external_marks;

        public string External_marks
        {
            get { return external_marks; }
            set { external_marks = value; }
        }
        private string third_marks;

        public string Third_marks
        {
            get { return third_marks; }
            set { third_marks = value; }
        }
        private string letter_grade;

        public string Letter_grade
        {
            get { return letter_grade; }
            set { letter_grade = value; }
        }
        private string gpa;

        public string Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }
        private string total_gpa;

        public string Total_gpa
        {
            get { return total_gpa; }
            set { total_gpa = value; }
        }
        private string total_credit;

        public string Total_credit
        {
            get { return total_credit; }
            set { total_credit = value; }
        }
        private string gpa_credit;

        public string Gpa_credit
        {
            get { return gpa_credit; }
            set { gpa_credit = value; }
        }
        private string fgpa;

        public string Fgpa
        {
            get { return fgpa; }
            set { fgpa = value; }
        }
        private string fcgpa;      // cgpa calculation

        public string Fcgpa
        {
            get { return fcgpa; }
            set { fcgpa = value; }
        }
        private string gpa_history; // course gpa for improvement

        public string Gpa_history
        {
            get { return gpa_history; }
            set { gpa_history = value; }
        }
        private string cgpa_history;

        public string Cgpa_history
        {
            get { return cgpa_history; }
            set { cgpa_history = value; }
        }
        private string semester_gpa_credit;

        public string Semester_gpa_credit
        {
            get { return semester_gpa_credit; }
            set { semester_gpa_credit = value; }
        }


        private string remarks;

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        private string viva_marks;          // viva voce

        public string Viva_marks
        {
            get { return viva_marks; }
            set { viva_marks = value; }
        }





        public void Insert()              // FOR INSERT STUDENT INTO student table
        {
            try
            {


                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection myconnection = new SqlConnection(str);

                string Query = "INSERT INTO [student](session,psession,roll,name,registration_no,sex,year,semester,gpa,cgpa,blood_group,mobile_no,email)VALUES ('" + this.Session + "','" + this.Psession + "','" + this.Roll + "','" + this.Name + "','" + this.Registration_no + "','" + this.Sex + "','" + this.Year + "','" + this.Semester + "','" + this.Gpa + "','" + this.Cgpa + "','" + this.Blood_group + "','" + this.Mobile_no + "','" + this.Email + "' )";
                SqlCommand Command = new SqlCommand(Query, myconnection);
                myconnection.Open();
                Command.ExecuteNonQuery();
                myconnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }



        public void Update()          // update student
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [student] SET session='" + this.Session + "',psession='" + this.Psession + "',name='" + this.Name + "',registration_no='" + this.Registration_no + "',sex='" + this.Sex + "',gpa='" + this.Gpa + "',cgpa='" + this.Cgpa + "' ,blood_group='" + this.Blood_group + "',mobile_no='" + this.Mobile_no + "',email='" + this.Email + "' where roll='" + this.Roll + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void Delete()                  // delete student
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "DELETE FROM [student] WHERE roll='" + this.Roll + "' and session='" + this.Session + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void Search()
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection myconnection = new SqlConnection(str);

                string Query = "Select * FROM [student] WHERE roll='" + this.Roll + "' session='" + this.Session + "' ";

                SqlCommand Command = new SqlCommand(Query, myconnection);
                myconnection.Open();
                Command.ExecuteNonQuery();
                myconnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public ArrayList search(string roll, string session)          // search student
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From student";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                roll = roll.ToLower();
                session = session.ToLower();

                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && session == (Convert.ToString(Reader["session"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Name = Convert.ToString(Reader["name"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Psession = Convert.ToString(Reader["psession"]);
                        add.Registration_no = Convert.ToString(Reader["registration_no"]);
                        add.Sex = Convert.ToString(Reader["sex"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        add.Cgpa = Convert.ToString(Reader["cgpa"]);
                        add.Blood_group = Convert.ToString(Reader["blood_group"]);
                        add.Mobile_no = Convert.ToString(Reader["mobile_no"]);
                        add.Email = Convert.ToString(Reader["email"]);


                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchroll(string roll)          // search roll for primary key
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From student";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                roll = roll.ToLower();
                //  session = session.ToLower();

                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Name = Convert.ToString(Reader["name"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Psession = Convert.ToString(Reader["psession"]);
                        add.Registration_no = Convert.ToString(Reader["registration_no"]);
                        add.Sex = Convert.ToString(Reader["sex"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Fgpa = Convert.ToString(Reader["gpa"]);
                        add.Fcgpa = Convert.ToString(Reader["cgpa"]);
                        add.Blood_group = Convert.ToString(Reader["blood_group"]);
                        add.Mobile_no = Convert.ToString(Reader["mobile_no"]);
                        add.Email = Convert.ToString(Reader["email"]);


                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public ArrayList Get()                   // for loading students information into edit,delete,display form
        {
            try
            {
                ArrayList list = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From student order by session,roll";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                while (Reader.Read())
                {
                    Add add = new Add();
                    add.Roll = Convert.ToString(Reader["roll"]);
                    add.Name = Convert.ToString(Reader["name"]);
                    add.Session = Convert.ToString(Reader["session"]);
                    add.Psession = Convert.ToString(Reader["psession"]);
                    add.Registration_no = Convert.ToString(Reader["registration_no"]);
                    add.Sex = Convert.ToString(Reader["sex"]);

                    // add.Current_semester_gpa = Convert.ToString(Reader["gpa"]);
                    //  add.Cgpa = Convert.ToString(Reader["cgpa"]);
                    add.Blood_group = Convert.ToString(Reader["blood_group"]);
                    add.Mobile_no = Convert.ToString(Reader["mobile_no"]);
                    add.Email = Convert.ToString(Reader["email"]);


                    list.Add(add);
                }
                Reader.Close();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public ArrayList Get1()                        //  // for loading teachers information into edit,delete,display form
        {
            try
            {
                ArrayList list = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From teacher";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                while (Reader.Read())
                {
                    Add add = new Add();

                    add.Name = Convert.ToString(Reader["name"]);
                    add.Designation = Convert.ToString(Reader["designation"]);
                    add.Dateofjoin = Convert.ToString(Reader["date_of_join"]);


                    add.Blood_group = Convert.ToString(Reader["blood_group"]);
                    add.Mobile_no = Convert.ToString(Reader["mobile_no"]);
                    add.Email = Convert.ToString(Reader["email"]);


                    list.Add(add);
                }
                Reader.Close();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        /*  public int pass(string passp, string passn)
          {
              try
              {
                  int temp = 0;

                  string ConnectionString = "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";
                  SqlConnection Connection = new SqlConnection(ConnectionString);

                  Connection.Open();

                  SqlCommand thisCommand1 = Connection.CreateCommand();
                  SqlCommand thisCommand2 = Connection.CreateCommand();

                  thisCommand1.CommandText = "SELECT password FROM login";

                  SqlDataReader thisReader1 = thisCommand1.ExecuteReader();

                  while (thisReader1.Read())
                  {
                      if (passp == Convert.ToString(thisReader1["password"]))
                      {
                          temp = 1;
                      }
                  }

                  thisReader1.Close();

                  if (temp == 1)
                  {
                      thisCommand2.CommandText = " UPDATE login set password='" + passn + "' where username='shajib' ";

                      thisCommand2.ExecuteNonQuery();
                      Connection.Close();

                      return 1;
                  }

                  else
                      return 0;
              }

              catch (Exception w)
              {
                  throw new Exception(w.Message, w);
              }
          }*/
        public int passcheck(string uname, string pass)
        {
            int count = 0;
            SqlConnection thisConnection = new SqlConnection("server=TAJNIN-PC\\SQLEXPRESS;database=cou;uid=sa;pwd=sa ;");
            // @"Server=emran-PC\emran;Integrated Security=True;" +
            // "Database=dept");
            thisConnection.Open();

            SqlCommand thisCommand = thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * from login";

            SqlDataReader thisReader = thisCommand.ExecuteReader();

            while (thisReader.Read())
            {
                if (uname == Convert.ToString(thisReader["username"]) && pass == Convert.ToString(thisReader["password"]))
                {
                    count = 1;

                }

            }

            thisReader.Close();
            thisConnection.Close();
            return count;
        }
        public void updateaccount()
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);//"Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;");

                string Query = "UPDATE [login] SET username='" + this.Username + "',password='" + this.Password + "'";
                SqlCommand command = new SqlCommand(Query, Connection);
                Connection.Open();
                command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        /*   public void InsertResult()
           {
               try
               {

                   string ConnectionString = "server=Emran-pc;database=Department;uid=sa;pwd=sa ;";// "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";

                   SqlConnection myconnection = new SqlConnection(ConnectionString);
                   string Query = "INSERT INTO [result](Roll,Attendance,Mid_Term_1,Mid_Term_2,Assignment,Presentation,Class_Test,Total_Marks)VALUES ('" + this.Roll + "','" + this.Attendance + "','" + this.Mid1 + "','" + this.Mid2 + "', '" + this.Assignment + "','" + this.Presentation + "','" + this.Classtest + "','" + this.Totalmarks + "' )";
                   SqlCommand Command = new SqlCommand(Query, myconnection);
                   myconnection.Open();
                   Command.ExecuteNonQuery();
                   myconnection.Close();
               }
               catch (Exception e)
               {
                   throw new Exception(e.Message, e);
               }
           }

           public void UpdateResult()                 //for result update
           {
               try
               {

                   string ConnectionString = "server=Emran-pc;database=Department;uid=sa;pwd=sa ;";// "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";
                   SqlConnection Connection = new SqlConnection(ConnectionString);

                   string Query = "UPDATE [student] SET Cgpa='" + this.Totalmarks + "' Where Roll='" + this.Roll + "' ";

                   SqlCommand Command = new SqlCommand(Query, Connection);
                   Connection.Open();
                   Command.ExecuteNonQuery();
                   Connection.Close();

               }
               catch (Exception e)
               {
                   throw new Exception(e.Message, e);
               }
           }
   */

        public void InsertSyllabus()         // for insert syllabus
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection myconnection = new SqlConnection(str);

                string Query = "INSERT INTO [syllabus](course_code,course_title,course_credit,year,semester)VALUES ('" + this.Course_code + "','" + this.Course_title + "','" + this.Course_credit + "','" + this.Year + "','" + this.Semester + "'  )";
                SqlCommand Command = new SqlCommand(Query, myconnection);
                myconnection.Open();
                Command.ExecuteNonQuery();
                myconnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public ArrayList GetSyllabus()                      //   for syllabus
        {
            try
            {
                ArrayList list = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From syllabus order by year,semester,course_code";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                while (Reader.Read())
                {
                    Add add = new Add();
                    add.Year = Convert.ToString(Reader["year"]);
                    add.Semester = Convert.ToString(Reader["semester"]);
                    add.Course_code = Convert.ToString(Reader["course_code"]);
                    add.Course_title = Convert.ToString(Reader["course_title"]);
                    add.Course_credit = Convert.ToString(Reader["course_credit"]);
                    list.Add(add);
                }
                Reader.Close();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public ArrayList searchSyllabus(string year, string semester)          // for search syllabus
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From syllabus order by year,semester,course_code";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                year = year.ToLower();
                semester = semester.ToLower();

                while (Reader.Read())
                {

                    if (year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();

                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Course_code = Convert.ToString(Reader["course_code"]);
                        add.Course_title = Convert.ToString(Reader["course_title"]);
                        add.Course_credit = Convert.ToString(Reader["course_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public void DeleteSyllabus()                           // for delete syllabus
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "DELETE FROM [syllabus] WHERE course_code='" + this.Course_code + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void UpdateSyllabus()              // for edit syllabus
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [syllabus] SET course_title='" + this.Course_title + "',course_credit='" + this.Course_credit + "',year='" + this.Year + "',semester='" + this.Semester + "' where course_code='" + this.Course_code + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public ArrayList searchCourse(string year, string semester)          // for loading course code,credit,title from syllabus
        {
            try
            {
                ArrayList listsearch = new ArrayList();
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From syllabus";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                year = year.ToLower();
                semester = semester.ToLower();

                while (Reader.Read())
                {

                    if (year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();

                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Course_code = Convert.ToString(Reader["course_code"]);
                        add.Course_title = Convert.ToString(Reader["course_title"]);
                        add.Course_credit = Convert.ToString(Reader["course_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }



        }


        public ArrayList searchCourseCode(string course_code)               //for loading course code,title,credit from syllabus
        {
            try
            {
                ArrayList listsearch = new ArrayList();
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From [syllabus]  ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                course_code = course_code.ToLower();


                while (Reader.Read())
                {

                    if (course_code == (Convert.ToString(Reader["course_code"])).ToLower())
                    {
                        Add add = new Add();


                        add.Course_code = Convert.ToString(Reader["course_code"]);
                        add.Course_title = Convert.ToString(Reader["course_title"]);
                        add.Course_credit = Convert.ToString(Reader["course_credit"]);




                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        /*   public void InsertBeforeFinal()         // for insert before final result
           {
               try
               {

                   string ConnectionString = "server=emran-pc\\sqlexpress;database=CSE;uid=sa;pwd=sa ;";// "Initial Catalog=CSE;Data Source=localhost;Integrated Security=SSPI;";

                   SqlConnection myconnection = new SqlConnection(ConnectionString);

                   string Query = "INSERT INTO [beforefinal](course_code,roll,year,semester,total_marks)VALUES ('" + this.Course_code + "','" + this.Roll + "','" + this.Year + "','" + this.Semester + "','" + this.Totalmarks + "' )";
                   SqlCommand Command = new SqlCommand(Query, myconnection);
                   myconnection.Open();
                   Command.ExecuteNonQuery();
                   myconnection.Close();
               }
               catch (Exception e)
               {
                   throw new Exception(e.Message, e);
               }
           }
           */

        public ArrayList searchRoll(string session)                // for loading roll from sessiont table
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From [student] order by roll  ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                session = session.ToLower();
                //  roll = roll.ToLower();

                while (Reader.Read())
                {

                    if (session == (Convert.ToString(Reader["session"])).ToLower())
                    {
                        Add add = new Add();
                        add.Session = Convert.ToString(Reader["session"]);

                        add.Roll = Convert.ToString(Reader["roll"]);






                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchSyllabus(string course_code)          // for loadin course title ,credit by course code for GPA calculation
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From syllabus order by year,semester,course_code";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                course_code = course_code.ToLower();


                while (Reader.Read())
                {

                    if (course_code == (Convert.ToString(Reader["course_code"])).ToLower())
                    {
                        Add add = new Add();


                        add.Course_code = Convert.ToString(Reader["course_code"]);
                        add.Course_title = Convert.ToString(Reader["course_title"]);
                        add.Course_credit = Convert.ToString(Reader["course_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchCourseCode(string year, string semester)         // loading course code from syllabus table by semester for GPA calculation
        {
            try
            {
                ArrayList listsearch = new ArrayList();
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From [syllabus]  ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                year = year.ToLower();
                semester = semester.ToLower();


                while (Reader.Read())
                {
                    if (year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();

                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);

                        add.Course_code = Convert.ToString(Reader["course_code"]);





                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void InsertGpa()         // for insert gpa calculation
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection myconnection = new SqlConnection(str);

                string Query = "INSERT INTO [gpa_calculation](roll,session,psession,year,semester,gpa,cgpa,gpa_history,gpa_credit,total_credit)VALUES ('" + this.Roll + "','" + this.Session + "','" + this.Psession + "','" + this.Year + "','" + this.Semester + "','" + this.Fgpa + "','" + this.Fcgpa + "','" + this.Gpa_history + "','" + this.Semester_gpa_credit + "','" + this.Total_credit + "' )";
                SqlCommand Command = new SqlCommand(Query, myconnection);
                myconnection.Open();
                Command.ExecuteNonQuery();
                myconnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList GetGPA()                      //   for display  gpa
        {
            try
            {
                ArrayList list = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_calculation order by session,roll,year,semester";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                while (Reader.Read())
                {
                    Add add = new Add();
                    add.Roll = Convert.ToString(Reader["roll"]);
                    add.Session = Convert.ToString(Reader["session"]);
                    add.Psession = Convert.ToString(Reader["psession"]);
                    add.Year = Convert.ToString(Reader["year"]);
                    add.Semester = Convert.ToString(Reader["semester"]);
                    add.Fgpa = Convert.ToString(Reader["gpa"]);
                    add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                    add.Fcgpa = Convert.ToString(Reader["cgpa"]);
                    // add.Cgpa_history = Convert.ToString(Reader["cgpa_history"]);
                    add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);
                    add.Total_credit = Convert.ToString(Reader["total_credit"]);
                    list.Add(add);
                }
                Reader.Close();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void DeleteGPA()                           // for delete gpa
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "DELETE FROM [gpa_calculation] WHERE roll='" + this.Roll + "'and session='" + this.Session + "'and  year='" + this.Year + "'and semester='" + this.Semester + "' ";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void UpdateGPA()              // for edit gpa
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [gpa_calculation] SET gpa='" + this.Fgpa + "',gpa_credit='" + this.Semester_gpa_credit + "',total_credit='" + this.Total_credit + "' where roll='" + this.Roll + "'and session='" + this.Session + "'and year='" + this.Year + "'and semester='" + this.Semester + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        public ArrayList searchGPA(string roll, string year, string semester)         // loading gpa from gpa_calculation table by (semester,year)
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From [gpa_calculation]  ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                // session = session.ToLower();
                roll = roll.ToLower();
                semester = semester.ToLower();
                year = year.ToLower();


                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();
                        // add.Session = Convert.ToString(Reader["session"]);
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Fgpa = Convert.ToString(Reader["gpa"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);






                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void InsertCGPA()         // for insert cgpa calculation
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection myconnection = new SqlConnection(str);

                string Query = "INSERT INTO [cgpa_calculation](roll,session,psession,cgpa,total_credit,remarks)VALUES ('" + this.Roll + "','" + this.Session + "','" + this.Psession + "','" + this.Fcgpa + "','" + this.Total_credit + "','" + this.Remarks + "'  )";
                SqlCommand Command = new SqlCommand(Query, myconnection);
                myconnection.Open();
                Command.ExecuteNonQuery();
                myconnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList GetCGPA()                      //   for DISPLAY cgpa
        {
            try
            {
                ArrayList list = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From cgpa_calculation order by session,roll";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                while (Reader.Read())
                {
                    Add add = new Add();
                    add.Roll = Convert.ToString(Reader["roll"]);
                    add.Session = Convert.ToString(Reader["session"]);
                    add.Psession = Convert.ToString(Reader["psession"]);
                    add.Fcgpa = Convert.ToString(Reader["cgpa"]);
                    add.Total_credit = Convert.ToString(Reader["total_credit"]);
                    add.Remarks = Convert.ToString(Reader["remarks"]);
                    list.Add(add);
                }
                Reader.Close();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void UpdateCGPA()              // for edit Cgpa
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [cgpa_calculation] SET cgpa='" + this.Cgpa + "',total_credit='" + this.Total_credit + "' where roll='" + this.Roll + "'and session='" + this.Session + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void UpdategpaCGPA()              // for edit Cgpa
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [gpa_calculation] SET cgpa='" + this.Fcgpa + "' where roll='" + this.Roll + "'and session='" + this.Session + "' and year='" + this.Year + "'and semester='2'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void UpdategpaCGPAhistory()              // for edit Cgpa
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [gpa_calculation] SET cgpa_history='" + this.Cgpa + "' where roll='" + this.Roll + "'and session='" + this.Session + "' and year='" + this.Year + "'and semester='2'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void DeleteCGPA()                           // for delete Cgpa
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "DELETE FROM [cgpa_calculation] WHERE roll='" + this.Roll + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }



        public void Deleteprevioussession()                           // for delete previous session
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "DELETE psession FROM [student] WHERE roll='" + this.Roll + "'  ";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchGPAroll(string roll, string year, string semester)          // for search gpa
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_calculation order by year,semester,roll";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                roll = roll.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();

                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Psession = Convert.ToString(Reader["Psession"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);

                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        add.Cgpa = Convert.ToString(Reader["cgpa"]);
                      //  add.Cgpa_history = Convert.ToString(Reader["cgpa_history"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public ArrayList searchEditGPAroll(string session, string roll)          // for search gpa in edit table
        {
            try
            {
                ArrayList listsearch = new ArrayList();
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_calculation order by year,semester ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                roll = roll.ToLower();
                // year = year.ToLower();
                session = session.ToLower();

                while (Reader.Read())
                {

                    if ((session == (Convert.ToString(Reader["session"])).ToLower() && roll == (Convert.ToString(Reader["roll"])).ToLower()) || roll == (Convert.ToString(Reader["roll"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Psession = Convert.ToString(Reader["Psession"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);

                        add.Fgpa = Convert.ToString(Reader["gpa"]);
                        add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        add.Cgpa = Convert.ToString(Reader["cgpa"]);
                        //  add.Cgpa_history = Convert.ToString(Reader["cgpa_history"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }




        public ArrayList searchGPAsession(string session, string year, string semester)          // for search gpa by session
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_calculation order by session,year,semester,roll";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                session = session.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();

                while (Reader.Read())
                {

                    if (session == (Convert.ToString(Reader["session"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Psession = Convert.ToString(Reader["Psession"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);

                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        add.Cgpa = Convert.ToString(Reader["cgpa"]);
                      //  add.Cgpa_history = Convert.ToString(Reader["cgpa_history"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchCGPAroll(string session, string roll)          // for search Cgpa by roll,session
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From cgpa_calculation";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                session = session.ToLower();
                roll = roll.ToLower();


                while (Reader.Read())
                {

                    if (session == (Convert.ToString(Reader["session"])).ToLower() && roll == (Convert.ToString(Reader["roll"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Psession = Convert.ToString(Reader["Psession"]);
                        add.Cgpa = Convert.ToString(Reader["cgpa"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        add.Remarks = Convert.ToString(Reader["remarks"]);
                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public ArrayList searchCGPAremarks(string session, string remarks)          // for search Cgpa by session,emarks
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From cgpa_calculation order by roll";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                session = session.ToLower();
                remarks = remarks.ToLower();


                while (Reader.Read())
                {

                    if (session == (Convert.ToString(Reader["session"])).ToLower() && remarks == (Convert.ToString(Reader["remarks"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Psession = Convert.ToString(Reader["Psession"]);
                        add.Cgpa = Convert.ToString(Reader["cgpa"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        add.Remarks = Convert.ToString(Reader["remarks"]);
                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchCGPAsession(string session)          // for search Cgpa by session
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From cgpa_calculation order by session,roll";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                session = session.ToLower();


                while (Reader.Read())
                {

                    if (session == (Convert.ToString(Reader["session"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Psession = Convert.ToString(Reader["Psession"]);
                        add.Cgpa = Convert.ToString(Reader["cgpa"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        add.Remarks = Convert.ToString(Reader["remarks"]);
                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void Updatecgpa()         // for insert cgpa to student table
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection myconnection = new SqlConnection(str);

                string Query = "update [student]set cgpa='" + this.Fcgpa + "' where roll='" + this.Roll + "'and session='" + this.Session + "'";
                SqlCommand Command = new SqlCommand(Query, myconnection);
                myconnection.Open();
                Command.ExecuteNonQuery();
                myconnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void Updategpa1(string session, string roll, string year, string semester)         // for insert gpa to student table
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection myconnection = new SqlConnection(str);

                string Query = "UPDATE [student] SET gpa='" + this.Fgpa + "',year='" + this.Year + "',semester='" + this.Semester + "' where roll='" + this.Roll + "'and session='" + this.Session + "'";
                SqlCommand Command = new SqlCommand(Query, myconnection);
                myconnection.Open();
                Command.ExecuteNonQuery();
                myconnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public void Updategpa()         // for insert gpa to student table
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection myconnection = new SqlConnection(str);

                string Query = "UPDATE [student] SET gpa='" + this.Fgpa + "',year='" + this.Year + "',semester='" + this.Semester + "' where roll='" + this.Roll + "'and session='" + this.Session + "'";
                SqlCommand Command = new SqlCommand(Query, myconnection);
                myconnection.Open();
                Command.ExecuteNonQuery();
                myconnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public ArrayList searchstudentbysession(string session)          // search student by session
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From student";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);


                session = session.ToLower();

                while (Reader.Read())
                {

                    if (session == (Convert.ToString(Reader["session"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Name = Convert.ToString(Reader["name"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Psession = Convert.ToString(Reader["psession"]);
                        add.Registration_no = Convert.ToString(Reader["registration_no"]);
                        add.Sex = Convert.ToString(Reader["sex"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Fgpa = Convert.ToString(Reader["gpa"]);
                        add.Fcgpa = Convert.ToString(Reader["cgpa"]);
                        add.Blood_group = Convert.ToString(Reader["blood_group"]);
                        add.Mobile_no = Convert.ToString(Reader["mobile_no"]);
                        add.Email = Convert.ToString(Reader["email"]);


                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        /* public void InsertTeacher()              //FOR INSERT teacher
            {
                try
                {

                    string ConnectionString = "server=TAJNIN-PC\\SQLEXPRESS;database=CSE;uid=sa;pwd=sa ;";// "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";

                    SqlConnection myconnection = new SqlConnection(ConnectionString);
                    string Query = "INSERT INTO [teacher](name,designation,date_of_join,blood_group,mobile_no,email)VALUES ('" + this.Name + "','" + this.Designation + "','" + this.Dateofjoin + "','" + this.Blood_group + "','" + this.Mobile_no + "','" + this.Email + "' )";
                    SqlCommand Command = new SqlCommand(Query, myconnection);
                    myconnection.Open();
                    Command.ExecuteNonQuery();
                    myconnection.Close();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }


            public void UpdateTeachers()          // update teachers
            {
                try
                {

                    string ConnectionString = "server=RUBEL-PC\\SQLEXPRESS;database=CSE;uid=sa;pwd=sa ;";// "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";
                    SqlConnection Connection = new SqlConnection(ConnectionString);

                    string Query = "UPDATE [teacher] SET designation='" + this.Designation + "',date_of_join='" + this.Dateofjoin + "' ,blood_group='" + this.Blood_group + "',mobile_no='" + this.Mobile_no + "',email='" + this.Email + "' where name='" + this.Name + "'";

                    SqlCommand Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }


            public void DeleteTeachers()                  // delete teachers info
            {
                try
                {
                    string ConnectionString = "server=RUBEL-PC\\SQLEXPRESS;database=CSE;uid=sa;pwd=sa ;";// "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";
                    SqlConnection Connection = new SqlConnection(ConnectionString);

                    string Query = "DELETE FROM [teacher] WHERE name='" + this.Name + "'";

                    SqlCommand Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }


            public ArrayList searchteacher(string name)          // search teacher by name
            {
                try
                {
                    ArrayList listsearch = new ArrayList();

                    string ConnectionString = "server=RUBEL-PC\\SQLEXPRESS;database=CSE;uid=sa;pwd=sa ;";// "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";
                    SqlConnection Connection = new SqlConnection(ConnectionString);

                    string Query = "SELECT * From teacher  ";
                    SqlCommand Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);


                    name =  name.ToLower();

                    while (Reader.Read())
                    {

                        if (name == (Convert.ToString(Reader["name"])).ToLower())
                        {
                            Add add = new Add();

                       
                            add.Name = Convert.ToString(Reader["name"]);
                            add.Designation = Convert.ToString(Reader["designation"]);
                            add.Dateofjoin = Convert.ToString(Reader["date_of_join"]);
                       
                            add.Blood_group = Convert.ToString(Reader["blood_group"]);
                            add.Mobile_no = Convert.ToString(Reader["mobile_no"]);
                            add.Email = Convert.ToString(Reader["email"]);


                            listsearch.Add(add);
                        }
                    }
                    Reader.Close();
                    return listsearch;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }


            public ArrayList searchteacherbydesignation(string designation)          // search teacher by designation
            {
                try
                {
                    ArrayList listsearch = new ArrayList();

                    string ConnectionString = "server=RUBEL-PC\\SQLEXPRESS;database=CSE;uid=sa;pwd=sa ;";// "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";
                    SqlConnection Connection = new SqlConnection(ConnectionString);

                    string Query = "SELECT * From teacher";
                    SqlCommand Command = new SqlCommand(Query, Connection);
                    Connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);


                    designation = designation.ToLower();

                    while (Reader.Read())
                    {

                        if (designation == (Convert.ToString(Reader["designation"])).ToLower())
                        {
                            Add add = new Add();


                            add.Name = Convert.ToString(Reader["name"]);
                            add.Designation = Convert.ToString(Reader["designation"]);
                            add.Dateofjoin = Convert.ToString(Reader["date_of_join"]);

                            add.Blood_group = Convert.ToString(Reader["blood_group"]);
                            add.Mobile_no = Convert.ToString(Reader["mobile_no"]);
                            add.Email = Convert.ToString(Reader["email"]);


                            listsearch.Add(add);
                        }
                    }
                    Reader.Close();
                    return listsearch;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }
            */

        public void InsertGpaCourse()         // for insert gpa course calculation
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection myconnection = new SqlConnection(str);

                string Query = "INSERT INTO [gpa_course](roll,session,year,semester,course_code,course_title,course_credit,before_final,gpa,gpa_history,gpa_credit) VALUES ('" + this.Roll + "','" + this.Session + "','" + this.Year + "','" + this.Semester + "','" + this.Course_code + "','" + this.Course_title + "','" + this.Course_credit + "','" + this.Before_final + "','" + this.Gpa + "','" + this.Gpa_history + "','" + this.Gpa_credit + "' ) ";
                SqlCommand Command = new SqlCommand(Query, myconnection);
                myconnection.Open();
                Command.ExecuteNonQuery();
                myconnection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }


        public ArrayList GetCourseGPA()                      //   for display course gpa
        {
            try
            {
                ArrayList list = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_course order by roll,session,semester,course_code";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                while (Reader.Read())
                {
                    Add add = new Add();
                    add.Roll = Convert.ToString(Reader["roll"]);
                    add.Session = Convert.ToString(Reader["session"]);
                    add.Year = Convert.ToString(Reader["year"]);
                    add.Semester = Convert.ToString(Reader["semester"]);
                    add.Course_code = Convert.ToString(Reader["course_code"]);
                    add.Course_title = Convert.ToString(Reader["course_title"]);
                    add.Course_credit = Convert.ToString(Reader["course_credit"]);
                    add.Before_final = Convert.ToString(Reader["before_final"]);
                    add.Gpa = Convert.ToString(Reader["gpa"]);
                    add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                    // add.Total_credit = Convert.ToString(Reader["total_credit"]);
                    list.Add(add);
                }
                Reader.Close();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchrollbyyearsemester(string roll, string year, string semester)          // search * from gpa_calculation by roll,year,semester
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_calculation";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);


                roll = roll.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();

                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);

                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        //  add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }



        public ArrayList searchrollbyyearsemestercode(string roll, string year, string semester, string course_code)          // search * from gpa_course by roll,year,semester,code
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_course";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);


                roll = roll.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();
                course_code = course_code.ToLower();
                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower() && course_code == (Convert.ToString(Reader["course_code"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Course_code = Convert.ToString(Reader["course_code"]);
                        add.Course_credit = Convert.ToString(Reader["course_credit"]);
                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        add.Gpa_history = Convert.ToString(Reader["gpa_history"]);


                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void UpdateCourseGPA()              // for edit course_gpa
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [gpa_course] SET course_credit='" + this.Course_credit + "',before_final='" + this.Before_final + "',gpa='" + this.Gpa + "',gpa_credit='" + this.Gpa_credit + "' where roll='" + this.Roll + "'and  session='" + this.Session + "'and year='" + this.Year + "'and semester='" + this.Semester + "'and course_code='" + this.Course_code + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }


        public ArrayList searchCourseGPA(string roll, string session, string year, string semester)          // for search course_gpa
        {
            try
            {
                ArrayList listsearch = new ArrayList();
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_course order by course_code ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                roll = roll.ToLower();
                session = session.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();

                while (Reader.Read())
                {

                    if ((roll == (Convert.ToString(Reader["roll"])).ToLower() && session == (Convert.ToString(Reader["session"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower()) || (roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower()))
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Course_code = Convert.ToString(Reader["course_code"]);
                        add.Course_credit = Convert.ToString(Reader["course_credit"]);
                        //add.Before_final = Convert.ToString(Reader["before_final"]);
                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        //add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        // add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);
                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void DeleteCourseGPA()                           // for delete course gpa
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "DELETE FROM [gpa_course] WHERE roll='" + this.Roll + "'and session='" + this.Session + "'and  year='" + this.Year + "'and semester='" + this.Semester + "' ";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void UpdateCourseGPAHistory()              // for edit course_gpa history
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [gpa_course] SET gpa_history='" + this.Gpa + "' where roll='" + this.Roll + "'and  session='" + this.Session + "'and year='" + this.Year + "'and semester='" + this.Semester + "'and course_code='" + this.Course_code + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }


        public void UpdateGPAHistory()              // for edit gpa history
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [gpa_calculation] SET  gpa_history='" + this.Fgpa + "' where roll='" + this.Roll + "'and  session='" + this.Session + "'and year='" + this.Year + "'and semester='" + this.Semester + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }


        public ArrayList searchrollsession(string roll, string year, string semester, string session)          // search * from gpa_course by roll,sessoion
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_calculation";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);


                roll = roll.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();
                session = session.ToLower();
                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower() && session == (Convert.ToString(Reader["session"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        // add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchrollsession1(string roll, string year, string semester, string session)          // search * from gpa_course by roll,sessoion
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT gpa From gpa_calculation where roll='" + this.Roll + "' ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);


                roll = roll.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();
                session = session.ToLower();
                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower() && session == (Convert.ToString(Reader["session"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        // add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        // add.Total_credit = Convert.ToString(Reader["total_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }



        public ArrayList searchgpabyrollsession(string session, string roll)                // for loading gpa from gpa_calculation  table 
        {
            try
            {
                ArrayList listsearch = new ArrayList();
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From [gpa_calculation] order by year,semester,roll  ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                session = session.ToLower();
                roll = roll.ToLower();

                while (Reader.Read())
                {

                    if ((session == (Convert.ToString(Reader["session"])).ToLower() && roll == (Convert.ToString(Reader["roll"])).ToLower()) || roll == (Convert.ToString(Reader["roll"])).ToLower())
                    {
                        Add add = new Add();
                        add.Session = Convert.ToString(Reader["session"]);

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        add.Semester_gpa_credit = Convert.ToString(Reader["gpa_credit"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        //  add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);




                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchcgpabyrollsession(string session, string roll)                // for loading cgpa from cgpa_calculation  table 
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From [cgpa_calculation] order by session,roll  ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                session = session.ToLower();
                roll = roll.ToLower();

                while (Reader.Read())
                {

                    if (session == (Convert.ToString(Reader["session"])).ToLower() && roll == (Convert.ToString(Reader["roll"])).ToLower())
                    {
                        Add add = new Add();
                        add.Session = Convert.ToString(Reader["session"]);

                        add.Roll = Convert.ToString(Reader["roll"]);
                        // add.Year = Convert.ToString(Reader["year"]);
                        // add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        add.Fcgpa = Convert.ToString(Reader["cgpa"]);
                        // add.Semester_gpa_credit = Convert.ToString(Reader["gpa_credit"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        //  add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);




                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        /*  public void DeleteStudentGPA()                           // for delete gpa from student table
          {
              try
              {
                  string ConnectionString = "server=emran-pc\\sqlexpress;database=CSE;uid=sa;pwd=sa ;";// "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";
                  SqlConnection Connection = new SqlConnection(ConnectionString);

                  string Query = "DELETE year,semester,gpa FROM [student] WHERE roll='" + this.Roll + "'and session='" + this.Session + "'";

                  SqlCommand Command = new SqlCommand(Query, Connection);
                  Connection.Open();
                  Command.ExecuteNonQuery();
                  Connection.Close();
              }
              catch (Exception e)
              {
                  throw new Exception(e.Message, e);
              }
          }*/

        /* public void Searcht()
         {
             try
             {
                 string ConnectionString = "server=RUBEL-PC\\SQLEXPRESS;database=CSE;uid=sa;pwd=sa ;";// "Initial Catalog=Department;Data Source=localhost;Integrated Security=SSPI;";

                 SqlConnection myconnection = new SqlConnection(ConnectionString);

                 string Query = "Select * FROM [teacher] WHERE name like'abc%' ";

                 SqlCommand Command = new SqlCommand(Query, myconnection);
                 myconnection.Open();
                 Command.ExecuteNonQuery();
                 myconnection.Close();
             }
             catch (Exception e)
             {
                 throw new Exception(e.Message, e);
             }
         }
         */

        public ArrayList searchcoursegpa(string roll, string year, string semester)          // search * from gpa_course by roll,year,semester,code
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_course order by course_code";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);


                roll = roll.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();
                // course_code = course_code.ToLower();
                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Course_code = Convert.ToString(Reader["course_code"]);
                        add.Course_credit = Convert.ToString(Reader["course_credit"]);
                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);


                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchcoursecodedetails(string roll, string year, string semester, string course_code)          // search * from gpa_course by roll,year,semester,code
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_course order by course_code";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);


                roll = roll.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();
                course_code = course_code.ToLower();
                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower() && course_code == (Convert.ToString(Reader["course_code"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Course_code = Convert.ToString(Reader["course_code"]);
                        add.Course_title = Convert.ToString(Reader["course_title"]);
                        add.Course_credit = Convert.ToString(Reader["course_credit"]);
                        add.Before_final = Convert.ToString(Reader["before_final"]);
                        add.Gpa = Convert.ToString(Reader["gpa"]);
                        add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);


                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchCourseGPA_History(string roll, string session, string year, string semester, string course_code)          // for search course_gpa histoty
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_course order by course_code ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
                roll = roll.ToLower();
                session = session.ToLower();
                year = year.ToLower();
                semester = semester.ToLower();
                course_code = course_code.ToLower();
                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && session == (Convert.ToString(Reader["session"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower() && course_code == (Convert.ToString(Reader["course_code"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        add.Course_code = Convert.ToString(Reader["course_code"]);
                        // add.Course_credit = Convert.ToString(Reader["course_credit"]);
                        //add.Before_final = Convert.ToString(Reader["before_final"]);
                        // add.Gpa = Convert.ToString(Reader["gpa"]);
                        add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        // add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        //add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);
                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchpsession(string roll)                // for loading set previous session in cgpa_calv table 
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From [cgpa_calculation] where roll='" + this.Roll + "'   ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                //session = session.ToLower();
                roll = roll.ToLower();

                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Psession = Convert.ToString(Reader["psession"]);




                        // add.Year = Convert.ToString(Reader["year"]);
                        // add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        // add.Fcgpa = Convert.ToString(Reader["cgpa"]);
                        // add.Semester_gpa_credit = Convert.ToString(Reader["gpa_credit"]);
                        //  add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        //  add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);




                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchpsessioncgpatable(string session, string roll)                // for loading set previous session in student_calv table 
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From [cgpa_calculation]   ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                session = session.ToLower();
                roll = roll.ToLower();

                while (Reader.Read())
                {

                    if (roll == (Convert.ToString(Reader["roll"])).ToLower() && session == (Convert.ToString(Reader["session"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Psession = Convert.ToString(Reader["psession"]);




                        // add.Year = Convert.ToString(Reader["year"]);
                        // add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        // add.Fcgpa = Convert.ToString(Reader["cgpa"]);
                        // add.Semester_gpa_credit = Convert.ToString(Reader["gpa_credit"]);
                        //  add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        //  add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);




                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searchpsessionstudenttable(string session, string roll)                // for loading set previous session in student_calv table 
        {
            try
            {
                ArrayList listsearch = new ArrayList();
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From [student]   ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                session = session.ToLower();
                roll = roll.ToLower();

                while (Reader.Read())
                {

                    if ((roll == (Convert.ToString(Reader["roll"])).ToLower() && session == (Convert.ToString(Reader["session"])).ToLower()) || (roll == (Convert.ToString(Reader["roll"])).ToLower()))
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Psession = Convert.ToString(Reader["psession"]);




                        // add.Year = Convert.ToString(Reader["year"]);
                        // add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        // add.Fcgpa = Convert.ToString(Reader["cgpa"]);
                        // add.Semester_gpa_credit = Convert.ToString(Reader["gpa_credit"]);
                        //  add.Total_credit = Convert.ToString(Reader["total_credit"]);
                        //  add.Gpa_credit = Convert.ToString(Reader["gpa_credit"]);




                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }



        public void UpdatePsession()              // for edit previous session history
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [cgpa_calculation] SET  session='" + this.Psession + "' where roll='" + this.Roll + "' and  session='" + this.Session + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }





        public void UpdatePsessiongpatable()              // for edit previous session history gpa table
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [gpa_calculation] SET  session='" + this.Psession + "' where roll='" + this.Roll + "' and session='" + this.Session + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }


        public void UpdatePsessionstudenttable()              // for edit previous session history student table
        {
            try
            {

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [student] SET  session='" + this.Psession + "' where roll='" + this.Roll + "' and session='" + this.Session + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }


        public void UpdatePsessioncoursetable()              // for edit previous session history gpa course table
        {
            try
            {
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "UPDATE [gpa_course] SET  session='" + this.Psession + "' where roll='" + this.Roll + "' and session='" + this.Session + "'";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }



        public ArrayList searchgpabyyear(string session, string roll, string year)          // search * from previous semester gpa by year 
        {
            try
            {
                ArrayList listsearch = new ArrayList();
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = "SELECT * From gpa_calculation";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                session = session.ToLower();
                roll = roll.ToLower();

                year = year.ToLower();

                while (Reader.Read())
                {

                    if ((session == (Convert.ToString(Reader["session"])).ToLower() && roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower()) || roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower())
                    {
                        Add add = new Add();
                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        // add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        add.Fgpa = Convert.ToString(Reader["gpa"]);
                        // add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searcheditgpabysessionrollyearsemester(string session, string roll, string year, string semester)          // search * from previous semester gpa by year,session,roll,semester for improve or f removal 
        {
            try
            {
                ArrayList listsearch = new ArrayList();
                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = " SELECT * from gpa_calculation   ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                session = session.ToLower();
                roll = roll.ToLower();

                year = year.ToLower();                          // where session='" + this.Session + "'and roll='" + this.Roll + "' and year='" + this.Year + "'  except( SELECT * From gpa_calculation where session='" + this.Session + "'and roll='" + this.Roll + "' and year='" + this.Year + "'and  semester='" + this.Semester + "') 
                semester = semester.ToLower();
                while (Reader.Read())
                {

                    if (session == (Convert.ToString(Reader["session"])).ToLower() && roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower() || roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        // add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        add.Fgpa = Convert.ToString(Reader["gpa"]);
                        // add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        add.Total_credit = Convert.ToString(Reader["total_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public ArrayList searcheditgpabysessionrollyearsemesterstudenttable(string session, string roll, string year, string semester)          // search  gpa by year,session,roll,semester student table
        {
            try
            {
                ArrayList listsearch = new ArrayList();

                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = " SELECT * from student   ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);

                session = session.ToLower();
                roll = roll.ToLower();

                year = year.ToLower();                          // where session='" + this.Session + "'and roll='" + this.Roll + "' and year='" + this.Year + "'  except( SELECT * From gpa_calculation where session='" + this.Session + "'and roll='" + this.Roll + "' and year='" + this.Year + "'and  semester='" + this.Semester + "') 
                semester = semester.ToLower();
                while (Reader.Read())
                {

                    if (session == (Convert.ToString(Reader["session"])).ToLower() && roll == (Convert.ToString(Reader["roll"])).ToLower() && year == (Convert.ToString(Reader["year"])).ToLower() && semester == (Convert.ToString(Reader["semester"])).ToLower())
                    {
                        Add add = new Add();

                        add.Roll = Convert.ToString(Reader["roll"]);
                        add.Session = Convert.ToString(Reader["session"]);
                        add.Year = Convert.ToString(Reader["year"]);
                        add.Semester = Convert.ToString(Reader["semester"]);
                        // add.Course_code = Convert.ToString(Reader["course_code"]);

                        add.Fgpa = Convert.ToString(Reader["gpa"]);
                        // add.Gpa_history = Convert.ToString(Reader["gpa_history"]);
                        // add.Total_credit = Convert.ToString(Reader["total_credit"]);

                        listsearch.Add(add);
                    }
                }
                Reader.Close();
                return listsearch;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public void searcheditgpabysessionrollyearsemester1()          // search * from previous semester gpa by year,session,roll,semester for improve or f removal 
        {
            try
            {


                string str = System.Configuration.ConfigurationManager.AppSettings["myconn"];
                SqlConnection Connection = new SqlConnection(str);

                string Query = " SELECT * From gpa_calculation   where session='" + this.Session + "'and roll='" + this.Roll + "' and year='" + this.Year + "'  except( SELECT * From gpa_calculation where session='" + this.Session + "'and roll='" + this.Roll + "' and year='" + this.Year + "'and  semester='" + this.Semester + "')   ";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Command.ExecuteNonQuery();    // where session='" + this.Session + "'and roll='" + this.Roll + "' and year='" + this.Year + "'  except( SELECT * From gpa_calculation where session='" + this.Session + "'and roll='" + this.Roll + "' and year='" + this.Year + "'and  semester='" + this.Semester + "') 
                Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);

            }
        }

    }
}













