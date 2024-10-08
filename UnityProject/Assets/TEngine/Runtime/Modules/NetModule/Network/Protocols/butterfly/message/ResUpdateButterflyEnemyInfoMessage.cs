using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 更新地狱蝶对手信息 message
 */
public class ResUpdateButterflyEnemyInfoMessage : Message 
{
	//地狱蝶消息
	ButterflyOpponentInfo _opponentInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//地狱蝶消息
		SerializeUtils.WriteBean(stream, _opponentInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//地狱蝶消息
		_opponentInfo = SerializeUtils.ReadBean<ButterflyOpponentInfo>(stream);
	}
	
	/**
	 * 地狱蝶消息
	 */
	public ButterflyOpponentInfo OpponentInfo
	{
		set { _opponentInfo = value; }
	    get { return _opponentInfo; }
	}
	
	
	public override int GetId() 
	{
		return 211209;
	}
}