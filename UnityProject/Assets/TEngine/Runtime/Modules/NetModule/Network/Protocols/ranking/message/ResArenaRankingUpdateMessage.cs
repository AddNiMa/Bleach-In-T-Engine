using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 竞技场排行榜改变 message
 */
public class ResArenaRankingUpdateMessage : Message 
{
	//竞技场排行榜数据
	ArenaRankingBean _arenaRankingData;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//竞技场排行榜数据
		SerializeUtils.WriteBean(stream, _arenaRankingData);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//竞技场排行榜数据
		_arenaRankingData = SerializeUtils.ReadBean<ArenaRankingBean>(stream);
	}
	
	/**
	 * 竞技场排行榜数据
	 */
	public ArenaRankingBean ArenaRankingData
	{
		set { _arenaRankingData = value; }
	    get { return _arenaRankingData; }
	}
	
	
	public override int GetId() 
	{
		return 209102;
	}
}