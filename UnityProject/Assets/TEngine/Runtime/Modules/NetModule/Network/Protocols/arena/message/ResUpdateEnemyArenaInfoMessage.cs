using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 更新选中对手竞技场信息（竞技场变化了） message
 */
public class ResUpdateEnemyArenaInfoMessage : Message 
{
	//对手竞技场信息
	ArenaOpponentInfo _arenaInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对手竞技场信息
		SerializeUtils.WriteBean(stream, _arenaInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对手竞技场信息
		_arenaInfo = SerializeUtils.ReadBean<ArenaOpponentInfo>(stream);
	}
	
	/**
	 * 对手竞技场信息
	 */
	public ArenaOpponentInfo ArenaInfo
	{
		set { _arenaInfo = value; }
	    get { return _arenaInfo; }
	}
	
	
	public override int GetId() 
	{
		return 206106;
	}
}