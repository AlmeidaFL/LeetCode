namespace LeetCode;

class NumberofPeopleAwareofaSecret2327 {
    public int PeopleAwareOfSecret(int n, int delay, int forget) {
        var peopleQueue = new Queue<(int, int)>();
        var personIdIndex = 1;
        
        // On day 1, one person discovers a secret.
        peopleQueue.Enqueue((personIdIndex, 1));
        
        for (var i = 1; i <= n; i++)
        {
            var numberOfPeople = peopleQueue.Count;

            for (var j = 0; j < numberOfPeople; j++)
            {
                var (personId, daysKnowingSecret) = peopleQueue.Dequeue();

                if (daysKnowingSecret > forget)
                {
                    continue;
                }
                
                if (daysKnowingSecret > delay)
                {
                    var newPerson = ++personIdIndex;
                    peopleQueue.Enqueue((newPerson, 2));
                }

                peopleQueue.Enqueue((personId, ++daysKnowingSecret));
            }
        }

        return peopleQueue.Count % ((int)Math.Pow(10, 9) + 7);
    }
}