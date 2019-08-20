namespace Visitor
{
    class ManVisitor : Visitor
    {
        public override void TakeThingBriefcaseBag(BriefcaseBag briefcaseBad)
        {
            briefcaseBad.TakeDocuments();
        }

        public override void TakeThingSportsBag(SportsBag sportsBad)
        {
            sportsBad.TakeSneakers();
        }
    }
}
