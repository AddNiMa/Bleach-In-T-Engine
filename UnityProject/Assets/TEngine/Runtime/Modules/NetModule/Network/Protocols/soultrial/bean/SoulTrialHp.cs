using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵魂试炼角色血量
 */
public class SoulTrialHp : IMessageSerialize 
{
	//灵魂试炼角色id
	int _characterId;	
	//灵魂试炼角色剩余血量
	int _characterHp;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//灵魂试炼角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//灵魂试炼角色剩余血量
		SerializeUtils.WriteInt(stream, _characterHp);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//灵魂试炼角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//灵魂试炼角色剩余血量
		_characterHp = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 灵魂试炼角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 灵魂试炼角色剩余血量
	 */
	public int CharacterHp
	{
		set { _characterHp = value; }
	    get { return _characterHp; }
	}
	
}