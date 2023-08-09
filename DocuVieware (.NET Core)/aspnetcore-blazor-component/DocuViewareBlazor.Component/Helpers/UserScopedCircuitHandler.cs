using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.Extensions.Logging;

namespace DocuViewareBlazor.Component.Helpers;

/// <summary>
/// This circuit handler is a "scoped" service, and thus is available to each user/circuit separately.  This allows us to fetch and use the circuit id in a mechanism
///     that allows us to link circuitid and multiple tabs (same user) which is tracked in a "singleton" <see cref="MainApplicationStorage"/>. 
/// </summary>
internal class UserScopedCircuitHandler : CircuitHandler
{
    public string? CircuitId { get; private set; }

    private readonly ILogger _logger;

    public UserScopedCircuitHandler(
        ILogger<UserScopedCircuitHandler> logger)
    {
        _logger = logger;
    }


    public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        CircuitId = circuit.Id;
        return base.OnCircuitOpenedAsync(circuit, cancellationToken);
    }

    public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        return base.OnCircuitClosedAsync(circuit, cancellationToken);
    }

    public override Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        return base.OnConnectionDownAsync(circuit, cancellationToken);
    }

    public override Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        return base.OnConnectionUpAsync(circuit, cancellationToken);
    }
}
