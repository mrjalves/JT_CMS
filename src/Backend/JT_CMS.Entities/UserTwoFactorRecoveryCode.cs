namespace JT_CMS.Entities;

public class UserTwoFactorRecoveryCode
{
    public required string Code { get; set; }
    public bool Redeemed { get; set; }
}
