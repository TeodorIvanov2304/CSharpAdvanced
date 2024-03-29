﻿namespace BorderControl.Models
{
    public class BorderControl
    {
        private List<BaseEntity> entities; //Robots + Citizens
        private List<BaseEntity> detainedEntities;

        public List<BaseEntity> EntitiesToBeChecked { get => entities; }
        public BorderControl()
        {
            entities = new List<BaseEntity>();
        }

        
        public void AddForBorderCheck(BaseEntity entity)
        {
            entities.Add(entity);
        }
    }
}
