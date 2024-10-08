using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 所在番队积分和排名 message
 */
public class ResGangBattleScoreAndRankMessage : Message 
{
	//自己番队积分
	int _score;	
	//自己番队排名
	int _rank;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//自己番队积分
		SerializeUtils.WriteInt(stream, _score);
		//自己番队排名
		SerializeUtils.WriteInt(stream, _rank);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//自己番队积分
		_score = SerializeUtils.ReadInt(stream);
		//自己番队排名
		_rank = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 自己番队积分
	 */
	public int Score
	{
		set { _score = value; }
	    get { return _score; }
	}
	
	/**
	 * 自己番队排名
	 */
	public int Rank
	{
		set { _rank = value; }
	    get { return _rank; }
	}
	
	
	public override int GetId() 
	{
		return 112119;
	}
}