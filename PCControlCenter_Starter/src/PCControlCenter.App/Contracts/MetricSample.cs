using System;
namespace PCControlCenter.Contracts {
 public enum MetricQuality { Valid, Estimated, Unavailable, Stale, Error }
 public sealed class MetricSample {
  public string MetricId { get; set; }
  public double? Value { get; set; }
  public string Unit { get; set; }
  public DateTimeOffset Timestamp { get; set; }
  public string Source { get; set; }
  public MetricQuality Quality { get; set; }
 }
}
