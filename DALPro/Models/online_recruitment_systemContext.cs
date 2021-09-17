using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DALPro.Models
{
    public partial class online_recruitment_systemContext : DbContext
    {
        public online_recruitment_systemContext()
        {
        }

        public online_recruitment_systemContext(DbContextOptions<online_recruitment_systemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Academic> Academics { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobSeeker> JobSeekers { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=ABHIDELL;database=online_recruitment_system;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Academic>(entity =>
            {
                entity.HasKey(e => e.AcademicsId);

                entity.Property(e => e.AcademicsId)
                    .ValueGeneratedNever()
                    .HasColumnName("academics_id");

                entity.Property(e => e.AcademicsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("academics_name");

                entity.Property(e => e.JsId).HasColumnName("js_id");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Yop)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("YOP");

                entity.HasOne(d => d.Js)
                    .WithMany(p => p.Academics)
                    .HasForeignKey(d => d.JsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Academics__js_id__3A4CA8FD");
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.ToTable("Employer");

                entity.HasIndex(e => e.Email, "UQ__Employer__AB6E6164F1430278")
                    .IsUnique();

                entity.Property(e => e.EmployerId)
                    .ValueGeneratedNever()
                    .HasColumnName("Employer_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployerClients)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Employer_clients");

                entity.Property(e => e.EmployerInfo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employer_Info");

                entity.Property(e => e.EmployerName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Employer_name");

                entity.Property(e => e.EmployerPwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employer_pwd");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId)
                    .ValueGeneratedNever()
                    .HasColumnName("job_id");

                entity.Property(e => e.CurrentOpenings).HasColumnName("current_openings");

                entity.Property(e => e.EmployerId).HasColumnName("employer_id");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.JobCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("job_category");

                entity.Property(e => e.JobDesignation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("job_designation");

                entity.Property(e => e.JobLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("job_location");
            });

            modelBuilder.Entity<JobSeeker>(entity =>
            {
                entity.HasKey(e => e.JsId);

                entity.ToTable("JobSeeker");

                entity.HasIndex(e => e.JsEmail, "UQ__JobSeeke__45F44959B033B6D3")
                    .IsUnique();

                entity.HasIndex(e => e.JsResumeId, "UQ__JobSeeke__E7D17444839CA656")
                    .IsUnique();

                entity.Property(e => e.JsId)
                    .ValueGeneratedNever()
                    .HasColumnName("JS_id");

                entity.Property(e => e.JsAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JS_address");

                entity.Property(e => e.JsDob)
                    .HasColumnType("date")
                    .HasColumnName("JS_DOB");

                entity.Property(e => e.JsEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JS_email");

                entity.Property(e => e.JsJobId).HasColumnName("JS_job_id");

                entity.Property(e => e.JsMobile)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JS_mobile");

                entity.Property(e => e.JsName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("JS_name");

                entity.Property(e => e.JsPwd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("JS_pwd");

                entity.Property(e => e.JsResumeId).HasColumnName("JS_resume_id");

                entity.HasOne(d => d.JsJob)
                    .WithMany(p => p.JobSeekers)
                    .HasForeignKey(d => d.JsJobId)
                    .HasConstraintName("FK_JobSeeker_Jobs");

                entity.HasOne(d => d.JsResume)
                    .WithOne(p => p.JobSeeker)
                    .HasForeignKey<JobSeeker>(d => d.JsResumeId)
                    .HasConstraintName("FK__JobSeeker__JS_re__787EE5A0");
            });

            modelBuilder.Entity<Resume>(entity =>
            {
                entity.ToTable("Resume");

                entity.HasIndex(e => e.Email, "UQ_email")
                    .IsUnique();

                entity.Property(e => e.ResumeId)
                    .ValueGeneratedNever()
                    .HasColumnName("resume_id");

                entity.Property(e => e.AcademicId).HasColumnName("academic_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.ContactDetails)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("contact_details");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Organization)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("organization");

                entity.Property(e => e.Skills1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("skills1");

                entity.Property(e => e.Skills2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("skills2");

                entity.Property(e => e.Skills3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("skills3");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.HasOne(d => d.Academic)
                    .WithMany(p => p.Resumes)
                    .HasForeignKey(d => d.AcademicId)
                    .HasConstraintName("FK__Resume__academic__7D439ABD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
