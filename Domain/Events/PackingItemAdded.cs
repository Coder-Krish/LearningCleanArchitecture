using Domain.Entities;
using Domain.ValueObjects;
using SharedAbstractions.Domain;

namespace Domain.Events;

public record PackingItemAdded(PackingList PackingList, PackingItem PackingItem) : IDomainEvent;
