using System.Collections.Generic;

namespace YgomSystem.Utility
{
	public class TaskManager
	{
		public delegate bool Task(ID tThis, int fExecNum, float fExecSec, object tParam);

		public class ID
		{
			protected object m_tId;

			protected int m_nCategory;

			protected ID()
			{
			}

			public int GetCategory()
			{
				return 0;
			}

			public bool IsRemoved()
			{
				return false;
			}
		}

		private class HighLevelID : ID
		{
			public void Reset(int nCategory, TaskData tTaskData)
			{
			}

			public void Clear()
			{
			}
		}

		private class TaskData
		{
			private Task m_tTask;

			private object m_tParam;

			private object m_tLocalData;

			private HighLevelID m_tId;

			private int m_nExecNum;

			private bool m_pause;

			private float m_nowSec;

			private float m_prevSec;

			private float m_timeSpeed;

			public TaskData()
			{
			}

			public TaskData(int nCategory, Task tTaskVal, object tParamVal)
			{
			}

			public void Terminate()
			{
			}

			public void Reset(int nCategory, Task tTaskVal, object tParamVal)
			{
			}

			public bool ExecuteTask()
			{
				return false;
			}

			public void Start()
			{
			}

			public void Pause(bool enable)
			{
			}

			public void ResetDeltaTimer()
			{
			}

			public void SetTimeSpeed(float speedRatio)
			{
			}

			public void Remove()
			{
			}

			public void SetLocalData(object data)
			{
			}

			public object GetLocalData()
			{
				return null;
			}

			public object GetParam()
			{
				return null;
			}

			public ID GetId()
			{
				return null;
			}

			public string GetTaskName()
			{
				return null;
			}

			public float GetNowTime()
			{
				return 0f;
			}

			public int GetExecNum()
			{
				return 0;
			}

			public bool CheckId(ID tID)
			{
				return false;
			}

			public bool CheckTask(Task tTask)
			{
				return false;
			}

			public bool IsTerminate()
			{
				return false;
			}

			public bool IsRemoved()
			{
				return false;
			}

			public bool IsPause()
			{
				return false;
			}
		}

		private class TaskCategoryData
		{
			private List<TaskData> m_lstTaskQue;

			private List<TaskData> m_lstNextTaskQue;

			private int m_nCategoryId;

			public TaskCategoryData(int categoryId)
			{
			}

			public bool Remove(ID tId, bool isReserve = false)
			{
				return false;
			}

			public bool RemoveAt(int nIndex, bool isReserve = false)
			{
				return false;
			}

			public void RemoveTask(Task tTask, bool isReserve = false)
			{
			}

			public void RemoveAll(bool isReserve = false)
			{
			}

			public void ImportNextTask()
			{
			}

			public void ClearRemoveTask()
			{
			}

			public void SetTaskTimeSpeed(float speedRatio)
			{
			}

			public void Pause(bool enable)
			{
			}

			public void ResetDeltaTimer()
			{
			}

			public List<TaskData> GetTaskQue()
			{
				return null;
			}

			public List<TaskData> GetNextTaskQue()
			{
				return null;
			}

			public int GetTaskIndex(ID tId)
			{
				return 0;
			}

			public TaskData GetTaskData(ID tId)
			{
				return null;
			}

			public List<TaskData> GetTaskTypeDataList(Task tTask)
			{
				return null;
			}

			public int GetCategoryId()
			{
				return 0;
			}

			public int GetTaskCount()
			{
				return 0;
			}

			public bool IsTaskType(Task tTask)
			{
				return false;
			}

			public bool IsTaskType(Task tTask, int index)
			{
				return false;
			}

			public string GetDebugString(List<TaskData> tTaskQue)
			{
				return null;
			}

			public bool CheckQueIndexEnable(int nIndex)
			{
				return false;
			}
		}

		private class TaskPool
		{
			private List<TaskData> m_pool;

			private int m_nowIndex;

			public TaskPool(int capacity)
			{
			}

			public TaskData New()
			{
				return null;
			}

			private void AddReserve(int num)
			{
			}
		}

		private static bool m_globalPause;

		private Dictionary<int, TaskCategoryData> m_tblTaskContainer;

		private TaskPool m_taskPool;

		private Dictionary<int, bool> m_pauseCategoryList;

		private Dictionary<int, float> m_timeSpeedCategoryList;

		private int m_executeTaskLimit;

		private bool m_executeTaskQueIndexReset;

		public static void GlobalPause(bool enable)
		{
		}

		public TaskManager(int reserveCategoryNum = 10, int reserveTaskNum = 50, int executeTaskLimit = 1000)
		{
		}

		public bool Execute(int nCategory, bool bClear, float limitTime = -1f)
		{
			return false;
		}

		public void ResetExecuteIndex()
		{
		}

		public void Pause(ID tId, bool enable)
		{
		}

		public void PauseCategory(int nCategory, bool enable)
		{
		}

		public void PauseAll(bool enable)
		{
		}

		public ID Add(int nCategory, Task tTask, object tParam = null, bool startTimer = false)
		{
			return null;
		}

		public ID AddNext(int nCategory, Task tTask, object tParam = null, bool startTimer = false)
		{
			return null;
		}

		public ID Insert(int nCategory, int nIndex, Task tTask, object tParam = null, bool startTimer = false)
		{
			return null;
		}

		public ID InsertNext(int nCategory, int nIndex, Task tTask, object tParam = null, bool startTimer = false)
		{
			return null;
		}

		public bool Remove(ID tId)
		{
			return false;
		}

		public bool RemoveAt(int nCategory, int nIndex)
		{
			return false;
		}

		public bool RemoveCategory(int nCategory)
		{
			return false;
		}

		public bool RemoveCategoryTask(int nCategory, Task tTask)
		{
			return false;
		}

		public bool RemoveAll()
		{
			return false;
		}

		public bool SetLocalData(ID tId, object data)
		{
			return false;
		}

		public bool SetTimeSpeed(ID tId, float speedRatio)
		{
			return false;
		}

		public bool SetTimeSpeed(int nCategory, float speedRatio)
		{
			return false;
		}

		public object GetParam(ID tId)
		{
			return null;
		}

		public object GetLocalData(ID tId)
		{
			return null;
		}

		public float GetTaskTime(ID tId)
		{
			return 0f;
		}

		public int GetTaskExecuteNum(ID tId)
		{
			return 0;
		}

		public ID GetTaskId(int nCategory, Task tTask, int nNum)
		{
			return null;
		}

		public ID GetTaskIndexId(int nCategory, int nIndex)
		{
			return null;
		}

		public int GetTaskIndex(ID tId)
		{
			return 0;
		}

		public string GetTaskName(ID tId)
		{
			return null;
		}

		public string GetTaskName(int nCategory, int nIndex = 1)
		{
			return null;
		}

		public string GetDebugInfo(int nCategory)
		{
			return null;
		}

		public int GetTaskNum(int nCategory)
		{
			return 0;
		}

		public int GetNextTaskNum(int nCategory)
		{
			return 0;
		}

		public bool IsEmpty(int nCategory)
		{
			return false;
		}

		public bool IsEmpty()
		{
			return false;
		}

		public bool IsTaskType(int nCategory, Task tTask)
		{
			return false;
		}

		public bool IsTaskType(int nCategory, int index, Task tTask)
		{
			return false;
		}

		private void SetCategoryPauseFlag(int nCategory, bool enable)
		{
		}

		private void SetCategoryTimeSpeed(int nCategory, float speedRatio)
		{
		}

		private TaskCategoryData GetTaskCategoryData(int nCategory)
		{
			return null;
		}

		private ID AddTaskData(bool bAddNextTaskQue, int nCategory, Task tTask, object tParam, bool startTimer)
		{
			return null;
		}

		private ID InsertTaskData(bool bAddNextTaskQue, int nCategory, int nIndex, Task tTask, object tParam, bool startTimer)
		{
			return null;
		}
	}
}
