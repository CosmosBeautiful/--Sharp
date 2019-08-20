namespace Observer
{
    class GroupAccountSubject : AbstractSubject
    {
        public string GroupName { get; set; }
        public ResourcesGroup ResourcesGroup { get; set; }

        public GroupAccountSubject(string groupName, ResourcesGroup resourcesGroup)
        {
            this.GroupName = groupName;
            this.ResourcesGroup = resourcesGroup;
        }
    }
}
