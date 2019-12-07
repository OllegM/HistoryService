using System;

namespace HistoryService.Controllers
{
  public class HistoryDto
  {
    public int id { get; set;}
    public string model{ get; set; }
    public string regNumber{ get; set; }
    public DateTime DateTimeOfManufacture{ get; set; }
    public int mileage{ get; set; }
    public DateTime DateTimeOfLastCheck{ get; set; }
    public string currentStatus{ get; set; }
    public DateTime DateTimeOfCurrentStatus{ get; set; }
    public string nextStatus{ get; set; }
    public DateTime DateTimeOfNextStatus{ get; set; }
    public long sequenceId{ get; set; }
    public DateTime eventDateTime{ get; set; }
    public string eventType{ get; set; }
    public string eventTypeDisplayName{ get; set; }
    public long locationId{ get; set; }
    public string locationAddress{ get; set; }
    public string locationType{ get; set; }
    public string locationTypeDisplayName{ get; set; }
  }
}