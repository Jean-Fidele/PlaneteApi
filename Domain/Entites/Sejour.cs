namespace Domain.Entites
{
    using System;

    public class Sejour
    {
        public int SejourId { get; set; }
        public TimeSpan? Checkin { get; set; }
        public TimeSpan? Checkout { get; set; }
    }
}
