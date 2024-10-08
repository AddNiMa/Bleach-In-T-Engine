using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 巅峰竞技场排行榜记录 message
 */
public class ResTopArenaRankingInfoMessage : Message 
{
	//对战记录列表
	List<TopArenaRankingInfo> _rankingInfo = new List<TopArenaRankingInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对战记录列表
		SerializeUtils.WriteShort(stream, (short)_rankingInfo.Count);

		foreach (var element in _rankingInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对战记录列表
		int _rankingInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankingInfo_length; ++i) 
		{
			_rankingInfo.Add(SerializeUtils.ReadBean<TopArenaRankingInfo>(stream));
		}
	}
	
	/**
	 * get 对战记录列表
	 * @return 
	 */
	public List<TopArenaRankingInfo> GetRankingInfo()
	{
		return _rankingInfo;
	}
	
	/**
	 * set 对战记录列表
	 */
	public void SetRankingInfo(List<TopArenaRankingInfo> rankingInfo)
	{
		_rankingInfo = rankingInfo;
	}
	
	
	public override int GetId() 
	{
		return 503108;
	}
}