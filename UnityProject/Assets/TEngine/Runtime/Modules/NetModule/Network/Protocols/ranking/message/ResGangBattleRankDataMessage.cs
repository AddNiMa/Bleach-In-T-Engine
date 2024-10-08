using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战排行榜数据 message
 */
public class ResGangBattleRankDataMessage : Message 
{
	//幸运番队信息
	GangBattleRankBean _luckyGang;	
	//番队战排行榜列表
	List<GangBattleRankBean> _gangBattleRankBean = new List<GangBattleRankBean>();
	//自己番队排名
	int _rank;	
	//自己番队积分
	int _score;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//幸运番队信息
		SerializeUtils.WriteBean(stream, _luckyGang);
		//番队战排行榜列表
		SerializeUtils.WriteShort(stream, (short)_gangBattleRankBean.Count);

		foreach (var element in _gangBattleRankBean)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//自己番队排名
		SerializeUtils.WriteInt(stream, _rank);
		//自己番队积分
		SerializeUtils.WriteInt(stream, _score);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//幸运番队信息
		_luckyGang = SerializeUtils.ReadBean<GangBattleRankBean>(stream);
		//番队战排行榜列表
		int _gangBattleRankBean_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _gangBattleRankBean_length; ++i) 
		{
			_gangBattleRankBean.Add(SerializeUtils.ReadBean<GangBattleRankBean>(stream));
		}
		//自己番队排名
		_rank = SerializeUtils.ReadInt(stream);
		//自己番队积分
		_score = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 幸运番队信息
	 */
	public GangBattleRankBean LuckyGang
	{
		set { _luckyGang = value; }
	    get { return _luckyGang; }
	}
	
	/**
	 * get 番队战排行榜列表
	 * @return 
	 */
	public List<GangBattleRankBean> GetGangBattleRankBean()
	{
		return _gangBattleRankBean;
	}
	
	/**
	 * set 番队战排行榜列表
	 */
	public void SetGangBattleRankBean(List<GangBattleRankBean> gangBattleRankBean)
	{
		_gangBattleRankBean = gangBattleRankBean;
	}
	
	/**
	 * 自己番队排名
	 */
	public int Rank
	{
		set { _rank = value; }
	    get { return _rank; }
	}
	
	/**
	 * 自己番队积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	
	public override int GetId() 
	{
		return 209109;
	}
}