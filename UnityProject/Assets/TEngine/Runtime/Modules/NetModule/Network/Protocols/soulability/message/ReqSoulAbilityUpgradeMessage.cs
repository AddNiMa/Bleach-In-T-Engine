using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求灵魂能力升级 message
 */
public class ReqSoulAbilityUpgradeMessage : Message 
{
	//角色id
	int _characterId;	
	//灵魂能力id
	int _soulabilityId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//灵魂能力id
		SerializeUtils.WriteInt(stream, _soulabilityId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//灵魂能力id
		_soulabilityId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 灵魂能力id
	 */
	public int SoulabilityId
	{
		set { _soulabilityId = value; }
	    get { return _soulabilityId; }
	}
	
	
	public override int GetId() 
	{
		return 304201;
	}
}