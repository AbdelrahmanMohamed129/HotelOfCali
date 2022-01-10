using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }
        //------------------------------------------Global QUERIES---------------------------------------------

        public void CheckOut(string RoomNO, string USSN)
        {
            SetNotOccupancy(RoomNO);
            int check = DeleteReservtion(RoomNO,USSN);
            if (check == 1)
                MessageBox.Show("Check out successful");
            else
                MessageBox.Show("This room isn't reserved by this user!");
        }

        //------------------------------------------Insert QUERIES---------------------------------------------
        public int InsertAccount(string fname, string minit, string lname, string username, string password, string gender, string bdate, string ssn, string mobile, string address)
        {
            try
            {
                string query = $"EXEC InsertAccount @username='{username}', @password='{password}'";
                int query_result = dbMan.ExecuteNonQuery(query);

                InsertUser(fname, minit, lname, username, gender, bdate, ssn, mobile, address);

                return query_result;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR");
                return 0;
            }
        }

        public int InsertCompanion(string fname, string minit, string lname, string ssn, string gender, string bdate, string relation)
        {
            string query = $"Insert into Companion values ('{fname}', '{minit}', '{lname}', {ssn}, '{gender}', '{bdate}', '{relation}')";
            return dbMan.ExecuteNonQuery(query);
        }


        private int InsertUser(string fname, string minit, string lname, string username, string gender, string bdate, string ssn, string mobile, string address)
        {
            try
            {
                string query = $"INSERT INTO [User](FName, Minit, LName, SSN, Gender, BirthDate, Address, MobileNO, UserName) " +
                               $"Values('{fname}', '{minit}', '{lname}', {ssn}, '{gender}', '{bdate}', '{address}', {mobile}, '{username}')";

                return dbMan.ExecuteNonQuery(query);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("User already exist");
                return 0;
            }
        }

        public int InsertEvent(string cost, string description, string startdate, string enddate)
        {
            try
            {
                string query = $"insert into Events (EventCost,Description,StartDate,EndDate) " +
                $"values({cost}, '{description}', '{startdate}', '{enddate}')";
                return dbMan.ExecuteNonQuery(query);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Event already exist");
                return 0;
            }
        }
        public int InsertRoom(string Roomtype, string ssn)
        {
            try
            {
                string query = $"insert into room (RoomType,Occupancy,Cleaned,ESSN) values ('{Roomtype}',0,'T',{ssn});";
                return dbMan.ExecuteNonQuery(query);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Room already exist");
                return 0;
            }
        }

        public DataTable CheckUserToReserveEvent(string username, string num)
        {
            string query = $"select 1 from Reservation r, [Events] e, [User] u " +
                $"where r.StartDate <= e.StartDate AND r.EndDate >= e.EndDate AND u.UserName = '{username}' AND e.EventNO = {num} AND u.SSN = r.USSN";
            return dbMan.ExecuteReader(query);
        }

        public int InsertAttendEvent(string username, string password, string num)
        {
            try
            {
                string ssn = SelectUserSSN(username, password).Rows[0][0].ToString();
                string query = $"Insert into Attend (USSN, EventNO) values ('{ssn}','{num}')";
                return dbMan.ExecuteNonQuery(query);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("User already attends this event");
                return 0;
            }
        }

        //-------------------------DELETE QUERIES-------------------------
        public int DeleteEvent(string num)
        {
            string query = $"DELETE FROM Events WHERE EventNO = {num}";
            return dbMan.ExecuteNonQuery(query);
        }


        public int DeleteRoom(string RoomNo)
        {
            string query = $"DELETE FROM Room WHERE RoomNO = {RoomNo}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteEmployee(string SSN)
        {
            string query = $"DELETE FROM Employee WHERE SSN = {SSN}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteEmployeeLoging(string Username)
        {
            string query = $"DELETE FROM LoginAccount WHERE UserName = '{Username}'";
            
            return dbMan.ExecuteNonQuery(query);
        }
        //-------------------------UPDATE QUERIES-------------------------

        public int UpdateRoomCleanStatus(string num)
        {
            string query = $"UPDATE Room SET Cleaned='T' WHERE RoomNO='{num}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEventCostInBill(string user, string event_num)
        {
            string query = $"update Bill " +
                $"set EventCost = EventCost + (select EventCost from [Events] where EventNO = {event_num}) " +
                $"where BillNO = (select r.BillNO from Reservation r, [User] u where UserName = '{user}' AND u.SSN = r.USSN)";
            return dbMan.ExecuteNonQuery(query);
        }


        public int InsertRerservation(string StartDate, string EndDate, string USSN, string RoomNO, int N)
        {
            try
            {
                int price = SelectPriceForBill(RoomNO);

                price = price * N;
                InsertBill(price.ToString());
                SetEventCostNulls();

                int temp = SelectLastBillNO();

                string query = $"INSERT INTO Reservation (StartDate,EndDate,USSN,RoomNO,BillNO)  Values ('{StartDate}','{EndDate}',{USSN},{RoomNO},{temp});";

                SetOccupancy(RoomNO);

                return dbMan.ExecuteNonQuery(query);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Room already reserved!");
                return 0;
            }

        }
        public int InsertBill(string RoomCost)
        {
            try
            {
                string query = $"INSERT INTO Bill (RoomCost) Values ({RoomCost});";
                SetEventCostNulls();
                return dbMan.ExecuteNonQuery(query);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR");
                return 0;
            }
        }
        public int InsertDependents(string FName,string LName,string ESSN,string gender,string relationship)
        {
            try
            {
                string query = $"INSERT INTO Dependents Values ('{FName}' ,'{LName}' , {ESSN} ,'{gender}' , '{relationship}');";
                return dbMan.ExecuteNonQuery(query);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Dependant already exists");
                return 0;
            }
        }
        public int InsertEmployee(string FName, string Minit,string LName, string SSN,string roleid,string gender, string BDate, string Address, string MobileNO, string SuperSSN, string salary, string username)
        {
            string query = $"INSERT INTO Employee  Values ('{FName}','{Minit}','{LName}',{SSN},'{roleid}','{gender}','{BDate}','{Address}','{MobileNO}',{SuperSSN},{salary},'{username}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertEmpAccount(string username,string password)
        {
            string query = $"INSERT INTO LoginAccount Values ('{username}','{password}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insert()
        {
            string query = $"INSERT INTO  Values ();";
            return dbMan.ExecuteNonQuery(query);
        }



        public int DeleteReservtion(string RoomNO, string USSN)
        {
            string query = $"DELETE FROM Reservation WHERE RoomNO = {RoomNO} and USSN = {USSN}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteDependents(string FName, string ESSN)
        {
            string query = $"DELETE FROM Dependents WHERE FName = '{FName}' and ESSN = {ESSN}";
            return dbMan.ExecuteNonQuery(query);
        }

        //------------------------------------------Update QUERIES---------------------------------------------


        public int Update()
        {
            string query = $"UPDATE SET WHERE ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateRoomStatus(string RoomNo)
        {
            string query = $"Update room set room.Cleaned = 'T' where room.RoomNO = {RoomNo}; ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEMPRole(string SSN,string role)
        {
            string query = $"Update Employee set RoleID = '{role}' where SSN = {SSN}; ";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEMPSalary(string SSN, string Salary)
        {
            string query = $"Update Employee set Salary = '{Salary}' where SSN = {SSN}; ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePassowrd(string username, string newpassword)
        {
            string query = $"EXEC UpdatePassword @username = '{username}', @newpassword = '{newpassword}'";
            return dbMan.ExecuteNonQuery(query);
        }


        public int SetEventCostNulls()
        {
            string query = $"UPDATE Bill SET Eventcost = 0 WHERE EventCost is NULL;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetOccupancy(string RoomNO)
        {
            string query = $"UPDATE Room SET Occupancy = 1 WHERE RoomNO = {RoomNO};";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetNotOccupancy(string RoomNO)
        {
            string query = $"UPDATE Room SET Occupancy = 0 WHERE RoomNO = {RoomNO};";
            return dbMan.ExecuteNonQuery(query);
        }


        //------------------------------------------SELECT QUERIES---------------------------------------------
        public DataTable Select()
        {
            string query = $"SELECT * FROM ;";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectRoomNO()
        {
            string query = $"select RoomNO from room ;";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectUserNameFromSSN(string SSN)
        {
            string query = $"SELECT UserName FROM Employee where SSN = {SSN} ;";

            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectUserNameFromSSNForUser(string SSN)
        {
            string query = $"SELECT UserName FROM [user] where SSN = {SSN};";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPassword(string Username)
        {
            string query = $"SELECT Password FROM LoginAccount where UserName = '{Username}';";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectResDetails(string ssn)
        {
            string query = $"Select Room.RoomNO, RoomType.RoomView, RoomType.RoomType, Reservation.StartDate, Reservation.EndDate from Room, RoomType, Reservation where Reservation.USSN = {ssn} and Room.RoomNO = Reservation.RoomNO and RoomType.RoomTypeID = Room.RoomType; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectUserSSN(string userName, string password)
        {
            string query = $"Select[User].SSN from[User], LoginAccount where LoginAccount.UserName = [User].UserName and LoginAccount.Password = '{password}' and[User].UserName = '{userName}'; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectRoomPriceYomna(string roomNo)
        {
            string query = $"Select RoomType.Price from RoomType, Room where Room.RoomNO = {roomNo} and Room.RoomType = RoomType.RoomTypeID ;";
            return dbMan.ExecuteReader(query);
        }

        //For the combox
        public DataTable SelectRoomNOFromReserveation()
        {
            string query = $"SELECT RoomNO FROM Reservation;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectUSSNFromReserveation()
        {
            string query = $"SELECT USSN FROM Reservation;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectUSSNForEvent()
        {
            string query = $"SELECT SSN FROM [User];";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectRoomType()
        {
            string query = $"(select RoomType from RoomType)  union (select RoomType from RoomType) ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectRoomView()
        {
            string query = $"(select RoomView from RoomType)  union (select RoomView from RoomType) ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelecthouskeepingSSN()
        {
            string query = $"select ssn from employee,Roles where employee.RoleID = roles.RoleID and employee.RoleID='HouEMP';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectRoomTypeID()
        {
            string query = $"select RoomTypeID from RoomType ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectRoleid(string username)
        {
            string query = $"SELECT RoleID FROM Employee where UserName='{username}';";
            return dbMan.ExecuteReader(query);
        }
        //For the combox
        public DataTable SelectAvailableRoomNumber(string RoomType, string RoomView, string startDate, string endDate)
        {
            string query = $"EXEC SelectAvailableRoomNum @RoomType = '{RoomType}', @RoomView = '{RoomView}', @startDate = '{startDate}', @endDate = '{endDate}'";
            // string query = $"(select RoomNO from Reservation where (select RoomNO from Room as R, RoomType as RT where RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.RoomType = RT.RoomTypeID) = RoomNO and (EndDate <= '{startDate}' OR StartDate >= '{endDate}')) union (select RoomNO from Room as R, RoomType as RT where RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.RoomType = RT.RoomTypeID and R.Occupancy = 0);";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAvailableRoomNumberPrice(string RoomType, string RoomView, string startDate, string endDate, string price)
        {
            string query = $"EXEC SelectAvailableRoomNumberPrice @RoomType = '{RoomType}', @RoomView = '{RoomView}', @startDate = '{startDate}', @endDate = '{endDate}', @price = '{price}'";

            //string query = $"(select RoomNO from Reservation where (select RoomNO from Room as R, RoomType as RT where RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.RoomType = RT.RoomTypeID and RT.Price <= {price}) = RoomNO and (EndDate <= '{startDate}' OR StartDate >= '{endDate}')) union (select RoomNO from Room as R, RoomType as RT where RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.RoomType = RT.RoomTypeID and R.Occupancy = 0  and RT.Price <= {price});";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectUserSSN()
        {
            string query = $"SELECT SSN FROM [User];";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeSSN()
        {
            string query = $"SELECT distinct SSN FROM Employee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectRoleID()
        {
            string query = $"(SELECT RoleID FROM Roles) except (SELECT RoleID FROM Roles where RoleID = 'MGR' or RoleID = 'CEO');";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectSSNForEditEmp()
        {
            string query = $"EXEC SelectSSNForEditEmp";
            //string query = $"select ssn from employee  except (SELECT e.SSN FROM Roles as r,Employee as e where (r.RoleID = 'MGR' or r.RoleID = 'CEO') and e.RoleID = r.RoleID);";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectSSNForEditMGR()
        {
            string query = $"SELECT e.SSN FROM Roles as r,Employee as e where (r.RoleID = 'MGR') and e.RoleID = r.RoleID;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeDEPSSN()
        {
            string query = $"SELECT distinct ESSN FROM Dependents;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDependentFName()
        {
            string query = $"SELECT distinct FName FROM Dependents;";
            return dbMan.ExecuteReader(query);
        }


        public int SelectLastBillNO()
        {
            string query = $"select max(BillNO) from Bill;";
            return (int)dbMan.ExecuteScalar(query);
        }


        public DataTable SelectEmployeeName(string username)
        {
            string query = $"EXEC SelectEmployeeName @user_username = '{username}'";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectAllEventsNumbers()
        {
            string query = $"Select EventNO from Events";
            return dbMan.ExecuteReader(query);
        }
        
        public DataTable SelectEvent(string num)
        {
            string query = $"Select * from Events where EventNO = '{num}'";
            return dbMan.ExecuteReader(query);
        }
        
        public DataTable SelectAllEvents()
        {
            string query = $"Select * from Events";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectRoomsToBeCleaned(string username)
        {
            string query = $"select RoomNO,Cleaned from Room, Employee where UserName = '{username}' AND ESSN = SSN";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectRoomsRequestClean(string username)
        {
            string query = $"select RoomNO from Room, Employee where UserName = '{username}' AND ESSN = SSN AND Cleaned='F'";
            return dbMan.ExecuteReader(query);
        }

        public int SelectPriceForBill(string RoomNO)
        {
            string query = $"select price from room as r, RoomType as rt where r.RoomType = rt.RoomTypeID and r.RoomNO = {RoomNO};";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable SelectRoomPrice(string RoomNO)
        {
            string query = $"select EventCost, RoomCost, (EventCost + RoomCost) as TotalCost from  Bill as b, Reservation as r where b.BillNO = r.BillNO and r.RoomNO = {RoomNO};" ;


            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectUserEvents(string username)
        {
            string query = $"select e.* " +
                $"from Attend a,[User] u,[Events] e " +
                $"where u.SSN = a.USSN AND u.UserName = '{username}'  AND e.EventNO = a.EventNO";
            return dbMan.ExecuteReader(query);
        }

        public int CheckDependentsPrimary(string Fname,string Lname,string ESSN)
        {
            string query = $"select count(*) from Dependents where Fname ='{Fname}' and LName = '{Lname}' and ESSN = {ESSN}";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int CheckLoginPrimary(string user)
        {
            string query = $"select count(*) from LoginAccount where UserName = '{user}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        //------------------------------------------Count QUERIES---------------------------------------------

        public int Count()
        {
            string query = $"SELECT COUNT() FROM ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int CountBills()
        {
            string query = $"Select Count(Bill.BillNO) from Bill ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int ExistAccount(string username, string password)
        {

            string query = $"select 1 where EXISTS(select UserName from LoginAccount where UserName = '{username}' AND[Password]= '{password}');";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int ExistAvailableRoom(string RoomType, string RoomView)
        {
            string query = $"EXEC ExistAvailableRoom @RoomType = '{RoomType},  @RoomView = '{RoomView}'';";
            // string query = $"select 1 where EXISTS(select R.Occupancy from RoomType as RT,Room as R where RT.RoomTypeID = R.RoomType and RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.Occupancy = 0);";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int ExistRoomToReserve(string RoomType, string RoomView, string startDate, string endDate)
        {
            string query = $"EXEC ExistRoomToReserve @RoomType = '{RoomType},  @RoomView = '{RoomView}',  @startDate = '{startDate}', @endDate = '{endDate}'';";
            //string query = $"select 1 from Reservation where (select RoomNO from Room as R, RoomType as RT where RT.RoomType = '{RoomType}' and RT.RoomView = '{RoomView}' and R.RoomType = RT.RoomTypeID) = RoomNO and (EndDate < '{startDate}' OR StartDate > '{endDate}');";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int CheckIfUserExists(string ssn)
        {
            string query = $"CheckIfUserExists @user_ssn = '{ssn}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
