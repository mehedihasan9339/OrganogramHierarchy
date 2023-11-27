namespace OrganogramHierarchy.Data
{
    public class OrganogramMaster
    {

        public int? Id { get; set; }
        public string? parentName { get; set; }
        public string? type { get; set; }
        public string? parentCode { get; set; }
        public int? parentId { get; set; }
        public string? imgUrl { get; set; }
    }
}
