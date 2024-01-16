﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private List<ToDoTask> _tasks = new List<ToDoTask>();

        public List<ToDoTask> Tasks { get { return _tasks; } set { _tasks = value; } }


        //This creates then adds a new task into the list.
        public void Add(string name)
        {
            ToDoTask newTask = new ToDoTask(name);
            Tasks.Add(newTask);
        }

        //This is the method that we looked at.
        public ToDoTask getTaskByID(int id)
        {
            ToDoTask returnedTask = new ToDoTask("not found");
            foreach (var task in Tasks)
            {
                if (task.TaskID == id)
                {
                    returnedTask = task;
                }
            }
            return returnedTask;
        }










        public DateTime getCreationTime(int id)
        {
            throw new NotImplementedException();
        }


        public void setStatusByID(int id, bool isCompleted)
        {
            throw new NotImplementedException();
        }

        public string updateName(int id, string newName)
        {
            string name = "noname";
            foreach (var task in Tasks)
            {
                if (task.TaskID == id)
                {
                    task.TaskName = newName;
                    name = task.TaskName;
                }
            }
            return name;
        }
    }


    public class ToDoTask
    {
        private static int _idCounter;
        private int _taskID;
        private string _taskName;
        private bool _isCompleted;
        private DateTime _created = new DateTime();

        public static int IDCounter { get { return _idCounter; } set { _idCounter = value; } }
        public int TaskID { get { return _taskID; } set { _taskID = value; } }
        public string TaskName { get { return _taskName; } set { _taskName = value; } }
        public bool IsCompleted { get { return _isCompleted; } set { _isCompleted = value; } }
        public DateTime Created { get { return _created; } set { _created = value; } }

        public ToDoTask(string taskName)
        {
            TaskID = IDCounter++;
            TaskName = taskName;
            IsCompleted = false;
            Created = DateTime.Now;
        }

    }
}
