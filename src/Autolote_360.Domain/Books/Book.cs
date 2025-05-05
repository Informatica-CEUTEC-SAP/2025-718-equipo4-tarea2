using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Autolote_360.Books;

public class Book : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
}