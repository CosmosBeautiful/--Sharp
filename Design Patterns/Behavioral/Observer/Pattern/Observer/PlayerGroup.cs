using System;

namespace Observer
{
    class PlayerGroup : Player, IObserver
    {
        public GroupAccountSubject GroupAccount { get; set; }
        public ResourcesGroup ResourcesGroup { get; set; }

        public PlayerGroup(string name, GroupAccountSubject groupAccount)
            : base(name)
        {
            this.GroupAccount = groupAccount;
            this.ResourcesGroup = new ResourcesGroup();
        }

        public void Update()
        {
            ResourcesGroup = GroupAccount.ResourcesGroup;
        }

        public void GoldExtractionResource(int goldResource)
        {
            ResourcesGroup.gold += goldResource;
            GroupAccount.Notify();
        }

        public void ForestExtractionResource(int forestResource)
        {
            ResourcesGroup.forest += forestResource;
            GroupAccount.Notify();
        }

        public void StatusPlayerGroup()
        {
            Console.WriteLine($"Игрок {Name}. Состоит в группе {GroupAccount.GroupName}, у группы золота: {ResourcesGroup.gold}, леса: {ResourcesGroup.forest}.");
        }
    }
}
