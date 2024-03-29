﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_ORM_DBFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HREntities : DbContext
    {
        public HREntities()
            : base("name=HREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
    
        public virtual int sp_InsertDept(string p_Dname, string p_Loc, string p_MgrName)
        {
            var p_DnameParameter = p_Dname != null ?
                new ObjectParameter("p_Dname", p_Dname) :
                new ObjectParameter("p_Dname", typeof(string));
    
            var p_LocParameter = p_Loc != null ?
                new ObjectParameter("p_Loc", p_Loc) :
                new ObjectParameter("p_Loc", typeof(string));
    
            var p_MgrNameParameter = p_MgrName != null ?
                new ObjectParameter("p_MgrName", p_MgrName) :
                new ObjectParameter("p_MgrName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertDept", p_DnameParameter, p_LocParameter, p_MgrNameParameter);
        }
    
        public virtual int sp_UpdateDept(Nullable<int> p_Deptno, string p_Dname, string p_Loc, string p_Mgr)
        {
            var p_DeptnoParameter = p_Deptno.HasValue ?
                new ObjectParameter("p_Deptno", p_Deptno) :
                new ObjectParameter("p_Deptno", typeof(int));
    
            var p_DnameParameter = p_Dname != null ?
                new ObjectParameter("p_Dname", p_Dname) :
                new ObjectParameter("p_Dname", typeof(string));
    
            var p_LocParameter = p_Loc != null ?
                new ObjectParameter("p_Loc", p_Loc) :
                new ObjectParameter("p_Loc", typeof(string));
    
            var p_MgrParameter = p_Mgr != null ?
                new ObjectParameter("p_Mgr", p_Mgr) :
                new ObjectParameter("p_Mgr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateDept", p_DeptnoParameter, p_DnameParameter, p_LocParameter, p_MgrParameter);
        }
    }
}
