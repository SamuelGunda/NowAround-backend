﻿namespace NowAround.Api.Models.Domain;

public class EstablishmentTag
{
    public int EstablishmentId { get; set; }
    public Establishment Establishment { get; set; }
    public int TagId { get; set; }
    public Tag Tag { get; set; }
}