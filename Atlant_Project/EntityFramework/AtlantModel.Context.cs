﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Atlant_Project.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using Atlant_Project.Class;

    public partial class AtlantEntities : DbContext
    {
        public AtlantEntities()
            : base(SingleConnection.ConString)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client_in_Group> Client_in_Group { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Instructor> Instructor { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<Time> Time { get; set; }
        public virtual DbSet<Time_off_weekday> Time_off_weekday { get; set; }
        public virtual DbSet<Weekday> Weekday { get; set; }
    
        public virtual int CIG_Delete(Nullable<int> id_client, Nullable<int> id_group)
        {
            var id_clientParameter = id_client.HasValue ?
                new ObjectParameter("id_client", id_client) :
                new ObjectParameter("id_client", typeof(int));
    
            var id_groupParameter = id_group.HasValue ?
                new ObjectParameter("id_group", id_group) :
                new ObjectParameter("id_group", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CIG_Delete", id_clientParameter, id_groupParameter);
        }
    
        public virtual int CIG_Insert(Nullable<int> id_client, Nullable<int> id_group)
        {
            var id_clientParameter = id_client.HasValue ?
                new ObjectParameter("id_client", id_client) :
                new ObjectParameter("id_client", typeof(int));
    
            var id_groupParameter = id_group.HasValue ?
                new ObjectParameter("id_group", id_group) :
                new ObjectParameter("id_group", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CIG_Insert", id_clientParameter, id_groupParameter);
        }
    
        public virtual int Client_Delete(Nullable<int> client_id)
        {
            var client_idParameter = client_id.HasValue ?
                new ObjectParameter("client_id", client_id) :
                new ObjectParameter("client_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Client_Delete", client_idParameter);
        }
    
        public virtual int Client_Insert(string firstName, string lastName, string phone, string gender, string adress)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Client_Insert", firstNameParameter, lastNameParameter, phoneParameter, genderParameter, adressParameter);
        }
    
        public virtual ObjectResult<Client_Select_Result> Client_Select(Nullable<int> client_id)
        {
            var client_idParameter = client_id.HasValue ?
                new ObjectParameter("client_id", client_id) :
                new ObjectParameter("client_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Client_Select_Result>("Client_Select", client_idParameter);
        }
    
        public virtual int Client_Update(Nullable<int> client_id, string firstName, string lastName, string phone, string gender, string adress)
        {
            var client_idParameter = client_id.HasValue ?
                new ObjectParameter("client_id", client_id) :
                new ObjectParameter("client_id", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Client_Update", client_idParameter, firstNameParameter, lastNameParameter, phoneParameter, genderParameter, adressParameter);
        }
    
        public virtual int Coachs_Delete(Nullable<int> id_coach)
        {
            var id_coachParameter = id_coach.HasValue ?
                new ObjectParameter("Id_coach", id_coach) :
                new ObjectParameter("Id_coach", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Coachs_Delete", id_coachParameter);
        }
    
        public virtual int Coachs_Insert(string firstName, string lastName, string phone, Nullable<int> exp, string vidSporta)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var expParameter = exp.HasValue ?
                new ObjectParameter("exp", exp) :
                new ObjectParameter("exp", typeof(int));
    
            var vidSportaParameter = vidSporta != null ?
                new ObjectParameter("VidSporta", vidSporta) :
                new ObjectParameter("VidSporta", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Coachs_Insert", firstNameParameter, lastNameParameter, phoneParameter, expParameter, vidSportaParameter);
        }
    
        public virtual ObjectResult<Coachs_Select_Result> Coachs_Select(Nullable<int> id_coach)
        {
            var id_coachParameter = id_coach.HasValue ?
                new ObjectParameter("Id_coach", id_coach) :
                new ObjectParameter("Id_coach", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Coachs_Select_Result>("Coachs_Select", id_coachParameter);
        }
    
        public virtual int Coachs_Update(string firstName, string lastName, string phone, Nullable<int> exp, string vidSporta, Nullable<int> id_coach)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var expParameter = exp.HasValue ?
                new ObjectParameter("exp", exp) :
                new ObjectParameter("exp", typeof(int));
    
            var vidSportaParameter = vidSporta != null ?
                new ObjectParameter("VidSporta", vidSporta) :
                new ObjectParameter("VidSporta", typeof(string));
    
            var id_coachParameter = id_coach.HasValue ?
                new ObjectParameter("id_coach", id_coach) :
                new ObjectParameter("id_coach", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Coachs_Update", firstNameParameter, lastNameParameter, phoneParameter, expParameter, vidSportaParameter, id_coachParameter);
        }
    
        public virtual ObjectResult<Group_Select_Result> Group_Select(Nullable<int> group_id)
        {
            var group_idParameter = group_id.HasValue ?
                new ObjectParameter("group_id", group_id) :
                new ObjectParameter("group_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Group_Select_Result>("Group_Select", group_idParameter);
        }
    
        public virtual int Groups_Delete(Nullable<int> id_group)
        {
            var id_groupParameter = id_group.HasValue ?
                new ObjectParameter("id_group", id_group) :
                new ObjectParameter("id_group", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Groups_Delete", id_groupParameter);
        }
    
        public virtual int Groups_Insert(string name, Nullable<int> maxKolLudei)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var maxKolLudeiParameter = maxKolLudei.HasValue ?
                new ObjectParameter("MaxKolLudei", maxKolLudei) :
                new ObjectParameter("MaxKolLudei", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Groups_Insert", nameParameter, maxKolLudeiParameter);
        }
    
        public virtual int Groups_Update(string name, Nullable<int> maxKolLudei, Nullable<int> id_group)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var maxKolLudeiParameter = maxKolLudei.HasValue ?
                new ObjectParameter("MaxKolLudei", maxKolLudei) :
                new ObjectParameter("MaxKolLudei", typeof(int));
    
            var id_groupParameter = id_group.HasValue ?
                new ObjectParameter("id_group", id_group) :
                new ObjectParameter("id_group", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Groups_Update", nameParameter, maxKolLudeiParameter, id_groupParameter);
        }
    
        public virtual ObjectResult<List_clients_in_group_Result> List_clients_in_group(Nullable<int> group_id)
        {
            var group_idParameter = group_id.HasValue ?
                new ObjectParameter("group_id", group_id) :
                new ObjectParameter("group_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<List_clients_in_group_Result>("List_clients_in_group", group_idParameter);
        }
    
        public virtual int Raspisanie_Delete(Nullable<int> schedule_id)
        {
            var schedule_idParameter = schedule_id.HasValue ?
                new ObjectParameter("schedule_id", schedule_id) :
                new ObjectParameter("schedule_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Raspisanie_Delete", schedule_idParameter);
        }
    
        public virtual int Raspisanie_Insert(Nullable<System.DateTime> day, Nullable<int> start_Time_id, Nullable<int> end_Time_id, Nullable<int> room_id, Nullable<int> group_id, Nullable<int> section_id, Nullable<int> trainer_id)
        {
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(System.DateTime));
    
            var start_Time_idParameter = start_Time_id.HasValue ?
                new ObjectParameter("Start_Time_id", start_Time_id) :
                new ObjectParameter("Start_Time_id", typeof(int));
    
            var end_Time_idParameter = end_Time_id.HasValue ?
                new ObjectParameter("End_Time_id", end_Time_id) :
                new ObjectParameter("End_Time_id", typeof(int));
    
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("Room_id", room_id) :
                new ObjectParameter("Room_id", typeof(int));
    
            var group_idParameter = group_id.HasValue ?
                new ObjectParameter("Group_id", group_id) :
                new ObjectParameter("Group_id", typeof(int));
    
            var section_idParameter = section_id.HasValue ?
                new ObjectParameter("Section_id", section_id) :
                new ObjectParameter("Section_id", typeof(int));
    
            var trainer_idParameter = trainer_id.HasValue ?
                new ObjectParameter("Trainer_id", trainer_id) :
                new ObjectParameter("Trainer_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Raspisanie_Insert", dayParameter, start_Time_idParameter, end_Time_idParameter, room_idParameter, group_idParameter, section_idParameter, trainer_idParameter);
        }
    
        public virtual ObjectResult<Schedule_Select_Result> Schedule_Select(Nullable<System.DateTime> day)
        {
            var dayParameter = day.HasValue ?
                new ObjectParameter("day", day) :
                new ObjectParameter("day", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Schedule_Select_Result>("Schedule_Select", dayParameter);
        }
    
        public virtual ObjectResult<Schedule_Select_Period_Result> Schedule_Select_Period(Nullable<System.DateTime> sPeriod, Nullable<System.DateTime> ePeriod)
        {
            var sPeriodParameter = sPeriod.HasValue ?
                new ObjectParameter("sPeriod", sPeriod) :
                new ObjectParameter("sPeriod", typeof(System.DateTime));
    
            var ePeriodParameter = ePeriod.HasValue ?
                new ObjectParameter("ePeriod", ePeriod) :
                new ObjectParameter("ePeriod", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Schedule_Select_Period_Result>("Schedule_Select_Period", sPeriodParameter, ePeriodParameter);
        }
    
        public virtual ObjectResult<Schedule_Select_Period_Room_Result> Schedule_Select_Period_Room(Nullable<int> room_id, Nullable<System.DateTime> sPeriod, Nullable<System.DateTime> ePeriod)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(int));
    
            var sPeriodParameter = sPeriod.HasValue ?
                new ObjectParameter("sPeriod", sPeriod) :
                new ObjectParameter("sPeriod", typeof(System.DateTime));
    
            var ePeriodParameter = ePeriod.HasValue ?
                new ObjectParameter("ePeriod", ePeriod) :
                new ObjectParameter("ePeriod", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Schedule_Select_Period_Room_Result>("Schedule_Select_Period_Room", room_idParameter, sPeriodParameter, ePeriodParameter);
        }
    
        public virtual ObjectResult<Schedule_Select_Period_Trainer_Result> Schedule_Select_Period_Trainer(Nullable<int> trainer_id, Nullable<System.DateTime> sPeriod, Nullable<System.DateTime> ePeriod)
        {
            var trainer_idParameter = trainer_id.HasValue ?
                new ObjectParameter("trainer_id", trainer_id) :
                new ObjectParameter("trainer_id", typeof(int));
    
            var sPeriodParameter = sPeriod.HasValue ?
                new ObjectParameter("sPeriod", sPeriod) :
                new ObjectParameter("sPeriod", typeof(System.DateTime));
    
            var ePeriodParameter = ePeriod.HasValue ?
                new ObjectParameter("ePeriod", ePeriod) :
                new ObjectParameter("ePeriod", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Schedule_Select_Period_Trainer_Result>("Schedule_Select_Period_Trainer", trainer_idParameter, sPeriodParameter, ePeriodParameter);
        }
    
        public virtual ObjectResult<Schedule_Select_Room_Result> Schedule_Select_Room(Nullable<int> room_id, Nullable<System.DateTime> day)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("day", day) :
                new ObjectParameter("day", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Schedule_Select_Room_Result>("Schedule_Select_Room", room_idParameter, dayParameter);
        }
    
        public virtual ObjectResult<Schedule_Select_Trainer_Result> Schedule_Select_Trainer(Nullable<int> trainer_id, Nullable<System.DateTime> day)
        {
            var trainer_idParameter = trainer_id.HasValue ?
                new ObjectParameter("trainer_id", trainer_id) :
                new ObjectParameter("trainer_id", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("day", day) :
                new ObjectParameter("day", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Schedule_Select_Trainer_Result>("Schedule_Select_Trainer", trainer_idParameter, dayParameter);
        }
    
        public virtual int Section_Delete(Nullable<int> id_section)
        {
            var id_sectionParameter = id_section.HasValue ?
                new ObjectParameter("id_section", id_section) :
                new ObjectParameter("id_section", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Section_Delete", id_sectionParameter);
        }
    
        public virtual int Section_Insert(string name, string desc)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Section_Insert", nameParameter, descParameter);
        }
    
        public virtual ObjectResult<Section_Select_Result> Section_Select(Nullable<int> id_section)
        {
            var id_sectionParameter = id_section.HasValue ?
                new ObjectParameter("id_section", id_section) :
                new ObjectParameter("id_section", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Section_Select_Result>("Section_Select", id_sectionParameter);
        }
    
        public virtual int Section_Update(Nullable<int> id_section, string name, string desc)
        {
            var id_sectionParameter = id_section.HasValue ?
                new ObjectParameter("id_section", id_section) :
                new ObjectParameter("id_section", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Section_Update", id_sectionParameter, nameParameter, descParameter);
        }
    
        public virtual int Users_Insert(string login, string password, string role)
        {
            var loginParameter = login != null ?
                new ObjectParameter("Login", login) :
                new ObjectParameter("Login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var roleParameter = role != null ?
                new ObjectParameter("Role", role) :
                new ObjectParameter("Role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Users_Insert", loginParameter, passwordParameter, roleParameter);
        }
    
        public virtual ObjectResult<string> Users_Role(Nullable<int> issqlrole)
        {
            var issqlroleParameter = issqlrole.HasValue ?
                new ObjectParameter("issqlrole", issqlrole) :
                new ObjectParameter("issqlrole", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Users_Role", issqlroleParameter);
        }
    
        public virtual ObjectResult<Users_Select_Result> Users_Select()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Users_Select_Result>("Users_Select");
        }
    
        public virtual int Users_Update(string login, string password, string role)
        {
            var loginParameter = login != null ?
                new ObjectParameter("Login", login) :
                new ObjectParameter("Login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var roleParameter = role != null ?
                new ObjectParameter("Role", role) :
                new ObjectParameter("Role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Users_Update", loginParameter, passwordParameter, roleParameter);
        }
    }
}