namespace LearningManSys.Models;

public class TrainingDAL
{
    public List<Training> GetAll()
    {
        using (lmsContext obj = new lmsContext())
        {
            Console.WriteLine("Inside GetAll");
            var data = from train in obj.Trainings select train;
            return data.ToList<Training>();
        }
    }

    public void Delete(int id)
    {
        using (var obj = new lmsContext())
        {
            obj.Trainings.Remove(obj.Trainings.Find(id));
            obj.SaveChanges();
        }
    }

    public Training GetById(int id)
    {
        using (var obj = new lmsContext())
        {
            var train = obj.Trainings.Find(id);
            return train;
        }
    }

    public void Insert(Training train)
    {
        using (var obj = new lmsContext())
        {
            obj.Trainings.Add(train);
            obj.SaveChanges();
        }
    }

    public void Update(Training train)
    {
        using (var obj = new lmsContext())
        {
            var Training = obj.Trainings.Find(train.Id);
            Training.Id = train.Id;
            Training.Topic = train.Topic;
            Training.Description = train.Location;
            Training.Faculty = train.Description;
            Training.Location = train.Location;
            obj.SaveChanges();
        }

    }
}