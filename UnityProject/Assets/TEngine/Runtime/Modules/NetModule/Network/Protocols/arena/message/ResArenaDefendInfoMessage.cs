using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 竞技场被挑战纪录 message
 */
public class ResArenaDefendInfoMessage : Message 
{
	//竞技场被挑战纪录列表
	List<ArenaDefendInfo> _arenaDefendInfo = new List<ArenaDefendInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//竞技场被挑战纪录列表
		SerializeUtils.WriteShort(stream, (short)_arenaDefendInfo.Count);

		foreach (var element in _arenaDefendInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//竞技场被挑战纪录列表
		int _arenaDefendInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _arenaDefendInfo_length; ++i) 
		{
			_arenaDefendInfo.Add(SerializeUtils.ReadBean<ArenaDefendInfo>(stream));
		}
	}
	
	/**
	 * get 竞技场被挑战纪录列表
	 * @return 
	 */
	public List<ArenaDefendInfo> GetArenaDefendInfo()
	{
		return _arenaDefendInfo;
	}
	
	/**
	 * set 竞技场被挑战纪录列表
	 */
	public void SetArenaDefendInfo(List<ArenaDefendInfo> arenaDefendInfo)
	{
		_arenaDefendInfo = arenaDefendInfo;
	}
	
	
	public override int GetId() 
	{
		return 206110;
	}
}