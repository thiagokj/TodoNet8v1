using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoApp.Core.Contexts.TodoContext.Entities;

namespace TodoApp.Infra.Contexts.TodoContext.Mappings;
public class TodoMap : IEntityTypeConfiguration<Todo>
{
    public void Configure(EntityTypeBuilder<Todo> builder)
    {
        builder.ToTable("Todo");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .HasColumnName("Title")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(120)
            .IsRequired(true);

        builder.Property(x => x.IsComplete)
            .HasColumnName("IsComplete")
            .HasColumnType("INTEGER")
            .HasDefaultValue(0);
    }
}