using System;
using System.Collections.Generic;

namespace DIYCraftsAndProjectsMVC.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public int UserId { get; set; }

    public string Content { get; set; } = null!;

    public int? ParentId { get; set; }

    public int SenderId { get; set; }

    public DateTime Sent { get; set; }

    public virtual ICollection<Notification> InverseParent { get; set; } = new List<Notification>();

    public virtual Notification? Parent { get; set; }

    public virtual User Sender { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

/*

SOLID

Single Responsibility Princip(SRP)
Klasa ima odgovornost da predstavlja stanje i ponašanje notifikacije u sustavu

Interface Segregation Princip (ISP)
Klase koje čitaju iz Notification-a koriste Interface umjesto direktno iz klase

*/




