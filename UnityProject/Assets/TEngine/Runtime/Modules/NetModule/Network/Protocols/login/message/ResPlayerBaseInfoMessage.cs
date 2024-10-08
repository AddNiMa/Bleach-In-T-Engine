using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家基本信息 message
 */
public class ResPlayerBaseInfoMessage : Message 
{
	//玩家基本信息
	PlayerBaseInfo _baseInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家基本信息
		SerializeUtils.WriteBean(stream, _baseInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家基本信息
		_baseInfo = SerializeUtils.ReadBean<PlayerBaseInfo>(stream);
	}
	
	/**
	 * 玩家基本信息
	 */
	public PlayerBaseInfo BaseInfo
	{
		set { _baseInfo = value; }
	    get { return _baseInfo; }
	}
	
	
	public override int GetId() 
	{
		return 100103;
	}
}