﻿using Orchard.ContentManagement;
using Orchard.Localization;

namespace Orchard.Recipes.Services {
    public abstract class RecipeBuilderStep : Component, IRecipeBuilderStep {
        public abstract string Name { get; }
        public abstract LocalizedString DisplayName { get; }
        public abstract LocalizedString Description { get; }
        public virtual int Priority { get { return 0; } }

        protected virtual string Prefix {
            get { return GetType().Name; }
        }

        public virtual dynamic BuildEditor(dynamic shapeFactory) {
            return null;
        }

        public virtual dynamic UpdateEditor(dynamic shapeFactory, IUpdateModel updater) {
            return null;
        }

        public virtual void Build(BuildContext context) {}
    }
}