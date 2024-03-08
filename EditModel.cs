namespace InputMultiSelectRepro
{
    public class EditModel
    {
        public long Id { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }
        public bool IsEmailVerified { get; set; }

        public List<(bool, string)> CurrentRoles { get; set; } = new List<(bool, string)>();
        public string[] SelectedRoles { get; set; } = [];
    }
}
