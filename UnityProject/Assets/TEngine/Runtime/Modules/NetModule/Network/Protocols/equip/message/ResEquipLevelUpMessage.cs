using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 装备升级返回 message
 */
public class ResEquipLevelUpMessage : Message 
{
	//0:成功 1:失败
	byte _ret;	
	//角色id
	int _characterId;	
	//装备id
	int _equipmentId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 1:失败
		SerializeUtils.WriteByte(stream, _ret);
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//装备id
		SerializeUtils.WriteInt(stream, _equipmentId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 1:失败
		_ret = SerializeUtils.ReadByte(stream);
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//装备id
		_equipmentId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功 1:失败
	 */
	public byte Ret
	{
		set { _ret = value; }
	    get { return _ret; }
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
	 * 装备id
	 */
	public int EquipmentId
	{
		set { _equipmentId = value; }
	    get { return _equipmentId; }
	}
	
	
	public override int GetId() 
	{
		return 103101;
	}
}