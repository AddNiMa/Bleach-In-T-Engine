using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求开始战斗 message
 */
public class ReqStartMemoryRoadBattleMessage : Message 
{
	//使用的角色编号
	int _characterId;	
	//自己支援角色的角色编号
	List<int> _supportCharacterId = new List<int>();
	//其他支援角色的角色编号
	List<long> _supportOtherPlayerId = new List<long>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//使用的角色编号
		SerializeUtils.WriteInt(stream, _characterId);
		//自己支援角色的角色编号
		SerializeUtils.WriteShort(stream, (short)_supportCharacterId.Count);

		foreach (var element in _supportCharacterId)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//其他支援角色的角色编号
		SerializeUtils.WriteShort(stream, (short)_supportOtherPlayerId.Count);

		foreach (var element in _supportOtherPlayerId)  
		{
			SerializeUtils.WriteLong(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//使用的角色编号
		_characterId = SerializeUtils.ReadInt(stream);
		//自己支援角色的角色编号
		int _supportCharacterId_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _supportCharacterId_length; ++i) 
		{
			_supportCharacterId.Add(SerializeUtils.ReadInt(stream));
		}
		//其他支援角色的角色编号
		int _supportOtherPlayerId_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _supportOtherPlayerId_length; ++i) 
		{
			_supportOtherPlayerId.Add(SerializeUtils.ReadLong(stream));
		}
	}
	
	/**
	 * 使用的角色编号
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * get 自己支援角色的角色编号
	 * @return 
	 */
	public List<int> GetSupportCharacterId()
	{
		return _supportCharacterId;
	}
	
	/**
	 * set 自己支援角色的角色编号
	 */
	public void SetSupportCharacterId(List<int> supportCharacterId)
	{
		_supportCharacterId = supportCharacterId;
	}
	
	/**
	 * get 其他支援角色的角色编号
	 * @return 
	 */
	public List<long> GetSupportOtherPlayerId()
	{
		return _supportOtherPlayerId;
	}
	
	/**
	 * set 其他支援角色的角色编号
	 */
	public void SetSupportOtherPlayerId(List<long> supportOtherPlayerId)
	{
		_supportOtherPlayerId = supportOtherPlayerId;
	}
	
	
	public override int GetId() 
	{
		return 220201;
	}
}