using System;
using System.Diagnostics;

namespace EDEngineer.Models.Filters
{
    [DebuggerDisplay("{Label}")]
    public class CraftableFilter : BlueprintFilter
    {
        public override string Label { get; }
        public Predicate<Blueprint> AppliesToDelegate { get; }

        public override bool AppliesTo(Blueprint blueprint)
        {
            return AppliesToDelegate(blueprint);
        }

        public CraftableFilter(string label, Predicate<Blueprint> appliesToDelegate, string uniqueName) : base(uniqueName)
        {
            Label = label;
            AppliesToDelegate = appliesToDelegate;
        }
    }
}