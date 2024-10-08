using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动条件达成
 */
public class ActivityTriggerBean : IMessageSerialize 
{
	//活动id
	int _id;	
	//已完成值
	int _progress;	
	//活动条件达成集合
	List<ActivityCondition> _condition = new List<ActivityCondition>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//活动id
		SerializeUtils.WriteInt(stream, _id);
		//已完成值
		SerializeUtils.WriteInt(stream, _progress);
		//活动条件达成集合
		SerializeUtils.WriteShort(stream, (short)_condition.Count);

		foreach (var element in _condition)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//活动id
		_id = SerializeUtils.ReadInt(stream);
		//已完成值
		_progress = SerializeUtils.ReadInt(stream);
		//活动条件达成集合
		int _condition_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _condition_length; ++i) 
		{
			_condition.Add(SerializeUtils.ReadBean<ActivityCondition>(stream));
		}
	}
	
	/**
	 * 活动id
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 已完成值
	 */
	public int Progress
	{
		set { _progress = value; }
	    get { return _progress; }
	}
	
	/**
	 * get 活动条件达成集合
	 * @return 
	 */
	public List<ActivityCondition> GetCondition()
	{
		return _condition;
	}
	
	/**
	 * set 活动条件达成集合
	 */
	public void SetCondition(List<ActivityCondition> condition)
	{
		_condition = condition;
	}
	
}