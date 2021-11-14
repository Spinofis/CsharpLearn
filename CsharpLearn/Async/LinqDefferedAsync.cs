using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearn.Async
{
    public class LinqDefferedAsync
    {
        public async Task<int[]> GetUsersAsync()
        {
            var userIds = new int[] { 1, 2, 3, 4, 5 };
            var getUserTasks = userIds.Select(id => GetUserAsync(id));
            return await Task.WhenAll(getUserTasks);
        }

        private async Task<int> GetUserAsync(int id)
        {
            await Task.Delay(1000);
            return id;
        }
    }
}
