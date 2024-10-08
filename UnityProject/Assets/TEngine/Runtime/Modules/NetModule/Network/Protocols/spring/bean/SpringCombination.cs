using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 温泉幸运组合
 */
public class SpringCombination : IMessageSerialize 
{
	//温泉id
	int _springId;	
	//组合id
	int _combinationId;	
	//刷新次数(目前是只有vip才能刷)
	int _refreshNum;	
	//玩家泡温泉已经遇到的幸运角色
	List<int> _meetCharacters = new List<int>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//温泉id
		SerializeUtils.WriteInt(stream, _springId);
		//组合id
		SerializeUtils.WriteInt(stream, _combinationId);
		//刷新次数(目前是只有vip才能刷)
		SerializeUtils.WriteInt(stream, _refreshNum);
		//玩家泡温泉已经遇到的幸运角色
		SerializeUtils.WriteShort(stream, (short)_meetCharacters.Count);

		foreach (var element in _meetCharacters)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//温泉id
		_springId = SerializeUtils.ReadInt(stream);
		//组合id
		_combinationId = SerializeUtils.ReadInt(stream);
		//刷新次数(目前是只有vip才能刷)
		_refreshNum = SerializeUtils.ReadInt(stream);
		//玩家泡温泉已经遇到的幸运角色
		int _meetCharacters_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _meetCharacters_length; ++i) 
		{
			_meetCharacters.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 温泉id
	 */
	public int SpringId
	{
		set { _springId = value; }
	    get { return _springId; }
	}
	
	/**
	 * 组合id
	 */
	public int CombinationId
	{
		set { _combinationId = value; }
	    get { return _combinationId; }
	}
	
	/**
	 * 刷新次数(目前是只有vip才能刷)
	 */
	public int RefreshNum
	{
		set { _refreshNum = value; }
	    get { return _refreshNum; }
	}
	
	/**
	 * get 玩家泡温泉已经遇到的幸运角色
	 * @return 
	 */
	public List<int> GetMeetCharacters()
	{
		return _meetCharacters;
	}
	
	/**
	 * set 玩家泡温泉已经遇到的幸运角色
	 */
	public void SetMeetCharacters(List<int> meetCharacters)
	{
		_meetCharacters = meetCharacters;
	}
	
}