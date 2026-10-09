using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace PCControlCenter.Contracts {
 public interface IMonitoringModule {
  string Id { get; }
  string DisplayName { get; }
  Task InitializeAsync(CancellationToken cancellationToken);
  Task<ModuleStatus> GetStatusAsync(CancellationToken cancellationToken);
  Task<IReadOnlyList<MetricSample>> CollectAsync(CancellationToken cancellationToken);
  Task StopAsync(CancellationToken cancellationToken);
 }
 public sealed class ModuleStatus { public bool IsAvailable { get; set; } public string Message { get; set; } }
}
