using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 竞技场排行榜 message
 */
public class ResArenaRankingInfoMessage : Message 
{
	//竞技场排行榜数据
	List<ArenaRankingBean> _arenaRankingData = new List<ArenaRankingBean>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//竞技场排行榜数据
		SerializeUtils.WriteShort(stream, (short)_arenaRankingData.Count);

		foreach (var element in _arenaRankingData)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//竞技场排行榜数据
		int _arenaRankingData_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _arenaRankingData_length; ++i) 
		{
			_arenaRankingData.Add(SerializeUtils.ReadBean<ArenaRankingBean>(stream));
		}
	}
	
	/**
	 * get 竞技场排行榜数据
	 * @return 
	 */
	public List<ArenaRankingBean> GetArenaRankingData()
	{
		return _arenaRankingData;
	}
	
	/**
	 * set 竞技场排行榜数据
	 */
	public void SetArenaRankingData(List<ArenaRankingBean> arenaRankingData)
	{
		_arenaRankingData = arenaRankingData;
	}
	
	
	public override int GetId() 
	{
		return 209101;
	}
}