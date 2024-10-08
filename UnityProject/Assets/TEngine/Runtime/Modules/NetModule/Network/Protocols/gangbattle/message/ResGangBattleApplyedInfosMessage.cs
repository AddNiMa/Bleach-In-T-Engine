using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 已报名玩家信息 message
 */
public class ResGangBattleApplyedInfosMessage : Message 
{
	//已报名玩家信息
	List<GangBattleFighterInfo> _fighterInfos = new List<GangBattleFighterInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//已报名玩家信息
		SerializeUtils.WriteShort(stream, (short)_fighterInfos.Count);

		foreach (var element in _fighterInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//已报名玩家信息
		int _fighterInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fighterInfos_length; ++i) 
		{
			_fighterInfos.Add(SerializeUtils.ReadBean<GangBattleFighterInfo>(stream));
		}
	}
	
	/**
	 * get 已报名玩家信息
	 * @return 
	 */
	public List<GangBattleFighterInfo> GetFighterInfos()
	{
		return _fighterInfos;
	}
	
	/**
	 * set 已报名玩家信息
	 */
	public void SetFighterInfos(List<GangBattleFighterInfo> fighterInfos)
	{
		_fighterInfos = fighterInfos;
	}
	
	
	public override int GetId() 
	{
		return 112102;
	}
}