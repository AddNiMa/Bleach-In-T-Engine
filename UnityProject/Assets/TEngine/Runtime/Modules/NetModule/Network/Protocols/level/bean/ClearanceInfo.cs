using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 通关信息
 */
public class ClearanceInfo : IMessageSerialize 
{
	//关卡难度Id
	int _levelDifficultyId;	
	//通关评价星星的index列表
	List<int> _evaluateStars = new List<int>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//关卡难度Id
		SerializeUtils.WriteInt(stream, _levelDifficultyId);
		//通关评价星星的index列表
		SerializeUtils.WriteShort(stream, (short)_evaluateStars.Count);

		foreach (var element in _evaluateStars)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//关卡难度Id
		_levelDifficultyId = SerializeUtils.ReadInt(stream);
		//通关评价星星的index列表
		int _evaluateStars_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _evaluateStars_length; ++i) 
		{
			_evaluateStars.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 关卡难度Id
	 */
	public int LevelDifficultyId
	{
		set { _levelDifficultyId = value; }
	    get { return _levelDifficultyId; }
	}
	
	/**
	 * get 通关评价星星的index列表
	 * @return 
	 */
	public List<int> GetEvaluateStars()
	{
		return _evaluateStars;
	}
	
	/**
	 * set 通关评价星星的index列表
	 */
	public void SetEvaluateStars(List<int> evaluateStars)
	{
		_evaluateStars = evaluateStars;
	}
	
}