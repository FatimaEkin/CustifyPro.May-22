using Custify.Domain.Enums;

namespace Custify.Domain;

public class GetCustomerDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public string GenderText { get; set; }
}
